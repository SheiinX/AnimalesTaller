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
        private string tamaño;
        private string origen;
        private int estado = 1;

        public Animal(string comida, string tamaño, string origen)
        {
            this.comida = comida;
            this.tamaño = tamaño;
            this.origen = origen;
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal: 'ñom ñom'");
        }

        public void CambiarEstado(int estadoAnimal)
        {/*
            if (estado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            */

            estado = estadoAnimal;

        }

        public virtual void HacerRuido()
        {
            Console.WriteLine("Animal: [Inserte Sonido]");
        }
    }
}
