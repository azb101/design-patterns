using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Live
{
    public class CharacterFactory
    {
        Dictionary<char, Character> dict = new Dictionary<char, Character>();

        public CharacterFactory()
        {
        }

        public Character GetCharacter(char val)
        {
            if (!dict.ContainsKey(val))
            {
                Type type = Type.GetType("FlyWeight.Live.Character" + char.ToUpper(val));

                if (type == null)
                    throw new Exception("type is not found");

                dict.Add(val, (Character)Activator.CreateInstance(type));
            }

            return dict[val];
        }
    }
}
