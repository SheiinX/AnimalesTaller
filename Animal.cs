using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    abstract class Animal
    {
        private string comida;
        private int tamaño;
        private string origen;
        private bool estado;

        public Animal(string comida, int tamaño, string origen)
        {
            this.comida = comida;
            this.tamaño = tamaño;
            this.origen = origen;
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal: 'ñom ñom'");
        }

        public bool CambiarEstado()
        {
            if (estado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void HacerRuido()
        {
            Console.WriteLine("Animal: [Inserte Sonido]");
        }
    }
}
