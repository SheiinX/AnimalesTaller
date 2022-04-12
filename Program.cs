using System;
using System.Collections.Generic;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Console.WriteLine("Programa para generar animales.");

            int i;
            bool flag = false;
            string nombre;

            do
            {
                Console.WriteLine("Por favor elija que animal quiere crear: \n1) Felino \n2) Canino \n3) Salir");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Por favor elija que felino quiere crear: \n1) León \n2) Tigre \n3) Gato");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                Leon leon = new Leon(0, "", "", "");
                                animals.Add(leon);
                                break;
                            case 2:
                                Tigre tigre = new Tigre(0, "", "", "");
                                animals.Add(tigre);
                                break;
                            case 3:
                                nombre = Console.ReadLine();
                                Gato gato = new Gato(nombre, 0, "", "", "");
                                animals.Add(gato);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Por favor elija que canino quiere crear: \n1) Perro \n2) Lobo");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:

                                break;
                            case 2:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Salir");
                        flag = true;
                        break;
                }
            }
            while (!flag);
        }
    }
}
