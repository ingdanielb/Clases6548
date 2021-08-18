using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Persona persona1 = new Persona();
            persona1.Nombre = "Pepe";
            persona1.Apellido = "Perez";
            persona1.Edad = 30;
            persona1.Estatura = 1.75;
            persona1.Peso = 80.7;
            //persona1.Salario = 3000000; 

            persona1.infoPersona();

            Persona persona2 = new Persona();
            persona2.Nombre = "Pepa";
            persona2.Apellido = "Perez";
            persona2.Edad = 28;
            persona2.Estatura = 1.78;
            persona2.Peso = 60.5;
            persona2.Salario = 3000000;

            persona2.infoPersona();

            System.Console.WriteLine(persona1.indiceMasaC());
            System.Console.WriteLine(persona2.indiceMasaC());
            
            persona1.alertaIMC(persona1.indiceMasaC());
            persona2.alertaIMC(persona2.indiceMasaC());

            Persona persona3 = new Persona("Daniel", "Benavides", 30, 1.70, 65, 0);
            persona3.infoPersona();
            persona3.alertaIMC(persona3.indiceMasaC()); */

            Hamburguesa h1 = new Hamburguesa();

            
            System.Console.WriteLine("Carne");
            bool carne = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Lechuga");
            bool lechuga = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Pepino");
            bool pepino = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Queso");
            bool queso = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Salsa de Tomate");
            bool salsaTomate = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Salsa Mostaza");
            bool salsaMostaza = bool.Parse(Console.ReadLine());

            
            h1.Carne = carne;
            h1.Lechuga = lechuga; 
            h1.Pepinos = pepino;
            h1.Queso = queso;
            h1.SalsaTomate = salsaTomate;
            h1.SalsaMostaza = salsaMostaza;

            //h1.pedido();

            Hamburguesa h2 = new Hamburguesa(carne, lechuga, pepino, queso, salsaTomate, salsaMostaza);

            h2.pedido();

            Hamburguesa.descuento(15000, 5);

            Hamburguesa.saludo();

        }
    }
}
