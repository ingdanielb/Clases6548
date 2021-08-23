using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregar elementos
            List<string> nombres = new List<string>();
            nombres.Add("Sofia");
            nombres.Add("Felipe");
            nombres.Add("Esteban");

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Escribe un nombre");
                string nombre = Console.ReadLine();
                if (nombres.Contains(nombre)) //Validamos si ya existe el valor en la lista
                {
                    Console.WriteLine("El nombre ya se encuentra registrado");
                }
                else
                {
                    nombres.Add(nombre);
                }
            }

            nombres.RemoveAt(1); //Eliminar elementos por indice
            //Mostramos elementos de una lista
            foreach (var item in nombres)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine(nombres.IndexOf("Esteban")); //Consultamos el indice de un elemento
            Console.WriteLine(nombres.Contains("Sofia"));

        }
    }
}
