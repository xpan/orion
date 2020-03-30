using Hydrogen.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Hydrogen
{
    public class SubscriptionManangerTests
    {
        [Fact]
        public void Test()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");
            var store = TableStore.Create(fsa, fsb);
            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);
            var sourceTable = Table.Create(store);
            var subManager = new SubscriptionManager(sourceTable);
            subManager.Subscribe(">,b,4i", (r, changeType, n) =>
            {
                Console.WriteLine("hello");
            });

            subManager.Insert(store, r =>
            {
                r.SetValue(fa, 0);
                r.SetValue(fb, 5);
            });
        }
    }
}
