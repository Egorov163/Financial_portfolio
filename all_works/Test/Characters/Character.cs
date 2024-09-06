using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Character
    {
        public Character(string name, int hp)
        {
            HP = hp;
            Name = name;
        }
        public int HP { get; private set; }
        public string Name { get; private set; }

        public virtual void PrintCharacter()
        {
            Console.WriteLine($"Меня зовут {Name}\nУ меня {HP} хп");
        }
    }
}
