using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Felino : Animal
    {
        public int tamañoGarras;

        public Felino(int tamañoGarras, string comida, int tamaño, string origen) : base(comida, tamaño, origen)
        {
            this.tamañoGarras = tamañoGarras;
        }
    }
}
