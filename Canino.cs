using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Canino : Animal
    {
        private string colorPelaje;

        public Canino(string colorPelaje, string comida, string tamaño, string origen) : base(comida, tamaño, origen)
        {
            this.colorPelaje = colorPelaje;
        }
    }
}
