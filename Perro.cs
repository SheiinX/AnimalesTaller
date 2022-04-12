using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Perro : Canino , IMascota
    {
        private string nombre;

        public Perro(string nombre, string colorPelaje, string comida, string tamaño, string origen) : base(colorPelaje, comida, tamaño, origen)
        {
            this.nombre = nombre;
        }

        public void Bañar()
        {
            Console.WriteLine("El perro se está bañando con champú");
        }

        public void SacarPasear()
        {

        }

        public void Vacunar()
        {
            Console.WriteLine("El perro ha sido vacunado de forma subcutánea");
        }

        public override void Comer()
        {
            Console.WriteLine("Perro: 'trau trau'");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("Perro: 'guau'");
        }
    }
}
