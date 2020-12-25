using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Joinable<T, K> : IJoinable where T: IEnumerator<K>
    {
        private Test<T> test;
        private Func<K, int, int> index;
        
        public Joinable(ITable table, 
            Test<T> test, 
            Func<K, int, int> index)
        {
            this.test = test;
            this.index = index;
            Table = table;
        }

        public ITable Table { get; }

        public void Test(ITable table, int index, ref T it)
        {
            test(table, index, ref it);
        }

        public int Index(K value, int i)
        {
            return index(value, i);
        }

        public IView View()
        {
            return new View<T, K>(this);
        }
    }
}
