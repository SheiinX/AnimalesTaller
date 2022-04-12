using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Tigre : Felino
    {
        public Tigre(int tamañoGarras, string comida, string tamaño, string origen) : base(tamañoGarras, comida, tamaño, origen)
        {

        }

        public override void Comer()
        {
            Console.WriteLine("Tigre: 'grau grau'");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("Tigre: 'grr'");
        }
    }
}
