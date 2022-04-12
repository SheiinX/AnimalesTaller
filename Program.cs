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

            string nombre, n1, n2, n3;

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
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Leon leon = new Leon(0, "", "", "");
                                animals.Add(leon);
                                break;
                            case 2:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Tigre tigre = new Tigre(0, "", "", "");
                                animals.Add(tigre);
                                break;
                            case 3:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
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
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                nombre = Console.ReadLine();
                                Perro perro = new Perro(nombre, "", "", "", "");
                                animals.Add(perro);
                                break;
                            case 2:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Lobo lobo = new Lobo("", "", "", "");
                                animals.Add(lobo);
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
