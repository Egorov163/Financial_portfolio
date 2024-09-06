using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Knight : Character, Warrior
    {
        public Knight(string name, int hp, int dmg) : base(name, hp)
        {
            DMG = dmg;
        }       
        public int DMG { get; private set; }

        public override void PrintCharacter()
        {
            Console.WriteLine($"Меня зовут {Name}\nУ меня {HP} хп\nУ меня {DMG} урона");
        }

        public void Battle()
        {
            throw new NotImplementedException();
        }
    }
}
