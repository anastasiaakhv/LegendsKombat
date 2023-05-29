using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Characters
{
    public class Barbarian : Character
    {
        public Barbarian()
        {
            SpecialAbility = "Rage";
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"Barbarian {Name} swings his mighty axe at {target.Name}!");
            target.Score -= 12;
            Score += 12;
        }

        public override void Defend()
        {
            Console.WriteLine($"Barbarian {Name} raises his shield!");
            Score += 6;
        }
    }
}
