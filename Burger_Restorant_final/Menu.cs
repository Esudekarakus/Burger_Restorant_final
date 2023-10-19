using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Restorant_final
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public double MenuFiyat { get; set; }
        public override string ToString()
        {
            return $"{this.MenuAdi} Menu";
        }
    }
}
