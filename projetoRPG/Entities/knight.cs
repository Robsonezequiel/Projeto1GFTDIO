﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType):base(Name, Level, HeroType)  
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}
