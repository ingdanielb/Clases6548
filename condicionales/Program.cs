using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int a = 50;
            int b = 10;
            int c = 56;
            if (a > b && a > c) System.Console.WriteLine("a es mayor que b y c");
            else if (b > a && b > c) System.Console.WriteLine("b es mayor que a y c");
            else System.Console.WriteLine("c es mayor que a y b");

            double hemoglobina = double.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'm')
            {
                if (hemoglobina < 13)
                {
                    System.Console.WriteLine("Baja");
                }
                else if (hemoglobina >= 13 && hemoglobina < 16)
                {
                    System.Console.WriteLine("Normal");
                }
            }
            else if (genero == 'f')
            {
                if (hemoglobina < 11)
                {
                    System.Console.WriteLine("Baja");
                }
                else if (hemoglobina >= 11 && hemoglobina < 15)
                {
                    System.Console.WriteLine("Normal");
                }
            }
            else
            {
                System.Console.WriteLine("Ingresaste un genero no valido");
            }
            System.Console.WriteLine("Escribe 1. Enero o 2. Febrero");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El mes de Enero tiene 31 dias");
                    break;
                case 2:
                    Console.WriteLine("El mes de Febrero tiene 28 o 29 dias");
                    break;
                default:
                    Console.WriteLine("Ingresa un valor correcto");
                    break;
            } */

            Console.WriteLine("Menu");
            Console.WriteLine("1. Hamburguesa \n2. Perro Caliente \n3. Salchipapa");
            Console.WriteLine("Elige una opcion");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita la cantidad de productos");
            int cantidadProductos = int.Parse(Console.ReadLine());

            int precioHam = 15000, precioPerro = 8000, precioSalch = 12000;
            int totalPago = 0;
            double desc = 0.05;

            switch (opcion)
            {
                case 1:
                    totalPago = precioHam * cantidadProductos;
                    if (cantidadProductos >= 5)
                    {
                        totalPago -= (int)(totalPago * desc);
                    }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                case 2:
                    totalPago = precioPerro * cantidadProductos;
                    if (cantidadProductos >= 5)
                    {
                        totalPago -= (int)(totalPago * desc);
                    }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                case 3:
                    totalPago = precioSalch * cantidadProductos;
                    if (cantidadProductos >= 5)
                    {
                        totalPago -= (int)(totalPago * desc);
                    }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                default:
                    Console.WriteLine("Debes elegir una opcion valida");
                    break;
            }

        }
    }
}


/* Categorias de edades
Niños 0-12
Jovenes 13- 29
Adultos 30 - 65
Adulto mayor 65 - 150
> 150 Edad no valida
 */


/* 
Lea el nombre, la edad, el sexo (1= femenino, 2= masculino) 
y el estado civil (1= soltero, 2 = casado, 3 = otro) de una persona y si el genero
es femenino, de estado civil soltera y la edad está entre 18 y 25 años, debe mostar
un mensaje "Bienvenida al club" sino "No cumples los requisitos para ingresar".

Si el genero es masculino de estado civil soltero y la edad está entre 18 y 38 años,
debe mostar un mensaje "Bienvenido al club" sino "No cumples los requisitos
para ingresar".
 */