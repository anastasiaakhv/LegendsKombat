using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string SpecialAbility { get; set; }

        public abstract void Attack(Character target);
        public abstract void Defend();

        public void UseSpecialAbility(Character target)
        {
            Console.WriteLine($"{Name} uses {SpecialAbility} on {target.Name}!");
        }
    }
}



