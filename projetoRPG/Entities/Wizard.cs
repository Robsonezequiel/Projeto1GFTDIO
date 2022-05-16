using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRPG.Entities
{
    public class Wizard : Hero
    {
     
        public Wizard(string Name, int Level, string HeroType) : base( Name,Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + "  Lançou Magia";
        }

        public string Attack(int bonus)
        {

            if(bonus > 6)
            {
                return this.Name + " Lançou magia SUPEREFETIVA com bonus de : " + bonus;
            }
            else
            {
                return this.Name + " Lançou magia com força fraca com bonus : " + bonus;
            }
           
        }
    }
}
