using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Characters
{
    public class Alchemist : Character
    {
        public Alchemist()
        {
            SpecialAbility = "Unstable Element";
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"Alchemist {Name} sprays burning acid at {target.Name}!");
            target.Score -= 10;
            Score += 10;
        }

        public override void Defend()
        {
            Console.WriteLine($"Alchemist {Name} raises a stone wall in front of him!");
            Score += 5;
        }
    }
}
