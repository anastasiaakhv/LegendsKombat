using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Characters
{
    public class Sorceress : Character
    {
        public Sorceress()
        {
            SpecialAbility = "Enchant";
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"Sorceress {Name} releases a bolt of magic energy at {target.Name}!");
            target.Score -= 15;
            Score += 15;
        }

        public override void Defend()
        {
            Console.WriteLine($"Sorceress {Name} creates a magical shield around her!");
            Score += 8;
        }
    }

}
