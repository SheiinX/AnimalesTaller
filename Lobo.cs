using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Lobo : Canino
    {
        public Lobo(string colorPelaje, string comida, string tamaño, string origen) : base(colorPelaje, comida, tamaño, origen)
        {
            
        }

        public override void Comer()
        {
            Console.WriteLine("Lobo: 'trr trr'");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("Lobo: 'wauuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu'");
        }
    }
}
