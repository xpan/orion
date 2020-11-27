using Hydrogen.Exprs;
using System;

namespace Hydrogen
{
    public class Joinable<T>
    {
        public Joinable(ITable table, Test<T> test, Snapshot<T> snapshot)
        {
            Table = table;
            Test = test;
            Snapshot = snapshot;
        }
        public Test<T> Test { get; }
        public ITable Table { get; }
        public Snapshot<T> Snapshot { get; }

        public void Deconstruct(out ITable table, out Test<T> test, out Snapshot<T> snapshot)
        {
            table = Table;
            test = Test;
            snapshot = Snapshot;
        }

        
    }
}
