using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Gato : Felino , IMascota
    {
        private string nombre;

        public Gato(string nombre, int tamañoGarras, string comida, int tamaño, string origen) : base(tamañoGarras, comida, tamaño, origen)
        {
            this.nombre = nombre;
        }

        public void Bañar()
        {
            Console.WriteLine("El gato se está bañando con jabón");
        }

        public void Vacunar()
        {
            Console.WriteLine("El gato fue vacunado de forma inocular");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato: 'gra gra'");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("Gato: 'miau'");
        }
    }
}
