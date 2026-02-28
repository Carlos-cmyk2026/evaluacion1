using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion1
{
    internal class Biblioteca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Biblioteca");

            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Mostrar libros");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese nombre del libro:");
                string libro = Console.ReadLine();
                Console.WriteLine("Libro registra: " + libro);
            }
            else
            {
                Console.WriteLine("Lista de libros...");
            }
        }
    }
}
 
