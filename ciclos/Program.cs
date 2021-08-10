using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //while - do-while - for - foreach 

            //while
            System.Console.WriteLine("Ingrese la cantidad de notas");
            int cantNotas = int.Parse(Console.ReadLine());
            /* int i = 1;
            double promedio = 0;
            while (i <= cantNotas)
            {
                Console.WriteLine("Ingrese la nota " + i);
                double nota = double.Parse(Console.ReadLine());
                promedio +=  nota;
                i++;
            }
                promedio = promedio / cantNotas;
                System.Console.WriteLine(promedio); */


            /* int j = 6;
            do
            {
                System.Console.WriteLine(j);
                j++;
            } while (j < 5);


            double promedio = 0;
            for (int i = 0; i < cantNotas; i++)
            {
                Console.WriteLine("Ingrese la nota " + i);
                double nota = double.Parse(Console.ReadLine());
                promedio +=  nota;
            }

            promedio= promedio / cantNotas;
            System.Console.WriteLine(promedio); */

            //Ciclos aninados
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Saludo");
                for (int k = 0; k < 1; k++)
                {
                    System.Console.WriteLine("Saludo desde otra dimension");
                }
            }


            //Solicitar la cantidad de productos a pagar
            //Solicitar el valor de cada producto
            //Mostar el total a pagar por los productos
            Console.WriteLine("Ingrese la cantidad de productos");
            int cantidadProductos = int.Parse(Console.ReadLine());
            int totalPago = 0;
            double descuento = 0.10;

            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine("Ingrese el valor del producto " + (i+1));
                int valorProducto = int.Parse(Console.ReadLine());
                totalPago += valorProducto;
            }

            if (totalPago > 50000)
            {
                totalPago -= (int)(totalPago * descuento);    
            }

            System.Console.WriteLine("El total a pagar es " + totalPago);

            //N cantidad de personas
            //Solicitar el valor del impuesto a pagar por cada persona
            //Impuesto predial > 500000 se aplica un descuento del 5%
            //total a pagar con el descuento(si aplica).

        }
    }
}
