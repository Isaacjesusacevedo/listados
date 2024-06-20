using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> pares = FiltrarPares(numeros);

            Console.WriteLine("Números originales:");
            ImprimirLista(numeros);

            Console.WriteLine("\nPares filtrados:");
            ImprimirLista(pares);
        }

        // Función para filtrar números pares
        public static List<int> FiltrarPares(List<int> numeros)
        {
            List<int> pares = numeros.Where(x => x % 2 == 0).ToList();
            return pares;
        }

        // Función para imprimir una lista de enteros
        public static void ImprimirLista(List<int> lista)
        {
            foreach (var num in lista)
            {
                Console.Write(num + " ");
            }
        }
    }
}