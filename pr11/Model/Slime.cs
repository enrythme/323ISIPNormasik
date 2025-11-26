using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr11.Model
{
    internal class Slime:Enemy
    {
        public Slime() : base(30, 5, 2)
        {
            Name = "Слайм";
            Defense += 2;
        }
    }
}
