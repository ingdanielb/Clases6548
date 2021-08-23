using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Perro p1 = new Perro("Firulai", 10, 4, "gris", 4);
            p1.ladrar();

            p1.infoAnimalPerro();

            p1.suscripcionVeterinaria(true);

            p1.correr(p1.Nombre, 50);

            System.Console.WriteLine("HOla");
            System.Console.WriteLine(p1.Nombre);
            System.Console.WriteLine(5+5);
        }


    }
}
