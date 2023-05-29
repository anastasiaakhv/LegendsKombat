using LegendsKombat.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Factories
{
    public class BarbarianFactory : CharacterFactory
    {
        public override Character CreateCharacter(string name)
        {
            return new Barbarian { Name = name };
        }
    }
}
