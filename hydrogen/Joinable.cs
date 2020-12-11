using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Joinable<T> : IJoinable
    {
        private Func<T, IEnumerable<(int ord, int index)>> facts;
        private Func<ITable, int, IEnumerable<T>> test;
        private Func<T, int, int> index;
        private Func<IEnumerable<T>> it;
        public Joinable(ITable table, 
            Func<ITable, int, IEnumerable<T>> test, 
            Func<IEnumerable<T>> it, 
            Func<T, IEnumerable<(int ord, int index)>> facts,
            Func<T, int, int> index)
        {
            this.it = it;
            this.test = test;
            this.facts = facts;
            this.index = index;
            Table = table;
        }

        public ITable Table { get; }

        public IEnumerable<T> Test(ITable table, int index)
        {
            return test(table, index);
        }

        public IEnumerable<T> It()
        {
            return it();
        }

        public IEnumerable<(int ord, int index)> Facts(T value)
        {
            return facts(value);
        }

        public int Index(T value, int i)
        {
            return index(value, i);
        }

        public IView View()
        {
            return new View<T>(this);
        }
    }
}
