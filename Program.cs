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
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Console.WriteLine("ingrense que comida quiere darle al leon ");
                                string comida = Console.ReadLine();
                                Console.WriteLine("ingrense que tamaño tendra el leon "); 
                                string tamaño = Console.ReadLine();
                                Console.WriteLine("ingrese que origen tendra el leon ");
                                string origen  = Console.ReadLine();
                                Leon leon = new Leon(3, comida, tamaño, origen);
                                animals.Add(leon);
                                Console.WriteLine($"la comida del leon es : {comida}");
                                leon.Comer();
                                Console.WriteLine($"el tamaño del León es  : {tamaño}");
                                Console.WriteLine($"el origen del León es   : {origen}");
                               
                                break;
                            case 2:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Console.WriteLine ("ingrese que comida quiere darle al tigre ");
                                string comidadetigre = Console.ReadLine();
                                Console.WriteLine("ingrese de que tamaño es el tigre ");
                                string tamañodetigre = Console.ReadLine();
                                Console.WriteLine("ingrense de que origen es el tigre ");
                                string origendetigre = Console.ReadLine();
                                Tigre tigre = new Tigre(0, comidadetigre, tamañodetigre, origendetigre);
                                animals.Add(tigre);
                                Console.WriteLine($"la comida del tigre es : {comidadetigre}");
                                tigre.Comer();
                                Console.WriteLine($" El tamaño del tigre es  : {tamañodetigre}");
                                Console.WriteLine($" El origen del tigre es  : {origendetigre}");
                                break;
                            case 3:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                Console.WriteLine("ingrese el nombre del gato ");
                                nombre  = Console.ReadLine();
                                Console.WriteLine("ingrense que comida le va a dar al gato ");
                                string comidagato = Console.ReadLine();
                                Console.WriteLine("ingrense el tamaño del gato ");
                                string tamñogato = Console.ReadLine();
                                Console.WriteLine("ingrense el origen dle gato");
                                string origengato = Console.ReadLine();

                                Gato gato = new Gato(nombre, 0, comidagato, tamñogato, origengato);
                                animals.Add(gato);
                                Console.WriteLine($" el nombre del gato es : {nombre}");
                                 Console.WriteLine($" la comida del gato es  : {comidagato}");
                                 gato.Comer();
                                 Console.WriteLine($" el tamaño del gato es : {tamñogato}");
                                 Console.WriteLine($" el origen del gato es : {origengato}");
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
                                Console.WriteLine("digite el nombre del perro ");
                                nombre = Console.ReadLine();
                                Console.WriteLine ("indique cual es el color del pelaje del perro");
                                string colorperro = Console.ReadLine();
                                Console.Write("ingrense que comida le va a dar al perro ");
                                string comidaperro = Console.ReadLine();
                                Console.WriteLine("indique de que tamaño es el perro");
                                string tamañoperro = Console.ReadLine();
                                Console.WriteLine("indique cual es el origen del perro");
                                string origenperro = Console.ReadLine();

                                Perro perro = new Perro(nombre, colorperro, comidaperro, tamañoperro, origenperro);
                                animals.Add(perro);
                                Console.WriteLine($" el nombre del perro es : {nombre}");
                                Console.WriteLine($" el color del peleje del perro es : {colorperro}");
                                Console.WriteLine($" la comida del perro es  : {comidaperro}");
                                perro.Comer();
                                Console.WriteLine($" el tamaño del perro es : {tamañoperro}");
                                Console.WriteLine($" el origen del perro es : {origenperro}");
                                break;
                            case 2:
                                //Crear los Console.ReadLine() para cada uno de los atributos de la clase y mostrarlo en consola
                                
                                Console.WriteLine ("indique cual es el color del pelaje del lobo");
                                string colorlobo = Console.ReadLine();
                                Console.Write("ingrense que comida le va a dar al lobo ");
                                string comidalobo = Console.ReadLine();
                                Console.WriteLine("indique de que tamaño es el lobo");
                                string tamañolobo = Console.ReadLine();
                                Console.WriteLine("indique cual es el origen del lobo");
                                string origenlobo = Console.ReadLine();
                                Lobo lobo = new Lobo(colorlobo, comidalobo, tamañolobo, origenlobo);
                                animals.Add(lobo);
                               
                                Console.WriteLine($" el color del peleje del lobo es : {colorlobo}");
                                Console.WriteLine($" la comida del lobo es  : {comidalobo}");
                                lobo.Comer();
                                Console.WriteLine($" el tamaño del lobo es : {tamañolobo}");
                                Console.WriteLine($" el origen del lobo es : {origenlobo}");
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
