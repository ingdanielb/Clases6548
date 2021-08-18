using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Perro p1 = new Perro("Firulai", 10, 4, "gris", 4);
            p1.ladrar();

            p1.infoAnimal();
        }


    }
}
