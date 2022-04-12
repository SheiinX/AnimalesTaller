using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Leon : Felino
    {
        public Leon(int tamañoGarras ,string comida, int tamaño, string origen) : base(tamañoGarras, comida, tamaño, origen)
        {

        }

        public override void Comer()
        {
            Console.WriteLine("León: 'arh arh'");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("León: 'raw'");
        }
    }
}
