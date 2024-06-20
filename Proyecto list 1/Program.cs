using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(32);
            numeros.Add(36);
            numeros.Add(4);
            numeros.Add(5);

            Console.WriteLine("El primer elemento de la lista es:" + numeros[0]);
            Console.WriteLine("El ultimo numero de este listado seria:" + numeros[numeros.Count - 1]);
            numeros.RemoveAt(2);
            int numerobuscado = 4;
            if (numeros.Contains(numerobuscado))
            {
                Console.WriteLine("El numero {numerobuscado} se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine("El numero {numerobuscado} no se encuentra en la lista.");
            }
        }
    }
}