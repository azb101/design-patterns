using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Canonical
{
    public class FlyweightFactory
    {
        Dictionary<string, Flyweight> dict = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            dict.Add("A", new ConcreteFlyweightA());
            dict.Add("B", new ConcreteFlyweightB());
            dict.Add("C", new ConcreteFlyweightC());
        }

        public Flyweight GetFlyWeight(string key)
        {
            if (!dict.ContainsKey(key))
                throw new Exception("does not contains key");

            return dict[key];
        }
    }
}
