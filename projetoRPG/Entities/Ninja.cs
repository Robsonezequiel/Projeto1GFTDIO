using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

            public override string Attack()
            {
            return this.Name + "  deu um chute";
            }


        public string Attack(int bonus)
        {

            if (bonus > 6)
            {
                return this.Name + " Deu um Chute SUPEREFETIVO com bonus de : " + bonus;
            }
            else
            {
                return this.Name + " Chutou fraco com bonus : " + bonus;
            }

        }
    
    }
}
