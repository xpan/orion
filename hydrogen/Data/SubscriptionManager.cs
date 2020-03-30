using Hydrogen.Data.Exprs.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen.Data
{
    public class SubscriptionManager
    {
        private Table table;
        private Dictionary<string, Table> tables = new Dictionary<string, Table>();
        private Dictionary<Table, List<Subscribe>> callbacks = new Dictionary<Table, List<Subscribe>>();
        private Dictionary<int, Subscribe> subscriptions = new Dictionary<int, Subscribe>();
        private int count = 0;
        public SubscriptionManager(Table table)
        {
            this.table = table;
        }

        public int Subscribe(string expr, Subscribe subscribe)
        {            
            if (!tables.ContainsKey(expr))
            {
                var (exprSub, succeeded) = Parsers.Parse(expr);
                if (!succeeded)
                {
                    throw new ArgumentException(nameof(expr));
                }

                tables[expr] = Table.Filter(table, exprSub);
            }

            var t = tables[expr];

            if (!callbacks.ContainsKey(t))
            {
                callbacks[t] = new List<Subscribe>();
            }

            var cbs = callbacks[t];
            cbs.Add(subscribe);
            var token = count++;
            subscriptions[token] = subscribe;
            return token;
        }

        public void Unsubscribe(int token)
        {
            if (subscriptions.ContainsKey(token))
            {
                var cb = subscriptions[token];
                subscriptions.Remove(token);

                foreach (var (_, cbs) in callbacks)
                {
                    if (cbs.Contains(cb))
                    {
                        cbs.Remove(cb);
                    }
                }
            }          
        }

        public void Insert(TableStore store, Action<Record> action)
        {
            var ts = tables.Values;

            var r = store.Insert();
            action(r);

            foreach (var t in ts)
            {
                var (_, _, test) = t;

                var cbs = callbacks[t];
                foreach (var arr in test(r))
                {
                    foreach (var cb in cbs)
                    {
                        cb(t[arr], ChangeType.Add, Enumerable.Empty<object>());
                    }
                }               
            }
        }

        public void UpdateRecord(Record record, Func<Record, IEnumerable<object>> action)
        {
            var ts = tables.Values;

            var vals = ts.ToDictionary(t => t, t => t.Test(record).ToArray());
            var fields = action(record);
            var nows = ts.ToDictionary(t => t, t => t.Test(record).ToArray());

            foreach (var t in ts)
            {
                var cbs = callbacks[t];

                foreach (var (arr, n) in Utils.SymmetricDiff(vals[t], nows[t]))
                {
                    foreach (var cb in cbs)
                    {
                        cb(t[arr], n, fields);
                    }
                }
            }
        }
    }
}
