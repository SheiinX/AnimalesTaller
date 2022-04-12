using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool flag = false;
            string n;

            do
            {

                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine("Salir");
                        flag = true;
                        break;
                }
            }
            while (!flag);
        }
    }
}
