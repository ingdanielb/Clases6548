using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Pepe";
            persona1.Apellido = "Perez";
            persona1.Edad = 30;
            persona1.Estatura = 1.75;
            persona1.Peso = 65.3;
            persona1.Salario = 3000000; 
            
            persona1.infoPersona();

        }
    }
}
