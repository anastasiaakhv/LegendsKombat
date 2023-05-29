using LegendsKombat.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendsKombat.Factories
{
    public abstract class CharacterFactory
    {
        public abstract Character CreateCharacter(string name);
    }
}
