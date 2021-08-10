using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] letras = new string[5];
            letras[0] = "b";
            letras[1] = "c";
            letras[2] = "d";
            letras[3] = "e";
            letras[4] = "f";

            System.Console.WriteLine(letras[4]);


            int[] numeros = { 23, 56, 89, 78, 45, 25 };
            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.Write(numeros[i] + " ");
            }

            foreach (var l in letras)
            {
                System.Console.WriteLine(l);
            }

            System.Console.WriteLine("Ingresa la cantidad de frutas");
            int cantFrutas = int.Parse(Console.ReadLine());
            string[] frutas = new string[cantFrutas];
            for (int i = 0; i < frutas.Length; i++)
            {
                System.Console.WriteLine("Ingresa una fruta");
                string fruta = Console.ReadLine();
                frutas[i] = fruta;
            }

            foreach (var item in frutas)
            {
                System.Console.Write(item + " ");
            } */
            System.Console.WriteLine("Ingresa la cantidad de frutas");
            int cantFrutas = int.Parse(Console.ReadLine());
            string[,] frutas = new string[cantFrutas,4];

            for (int i = 0; i < cantFrutas; i++)
            {
                System.Console.WriteLine("Ingresa los datos de la fruta " + i+1);
                for (int j = 0; j < 4; j++)
                {
                    string dato = Console.ReadLine();
                    frutas[i,j] = dato;
                }
            }

            int sumPrecioCompra = 0, sumPrecioVenta = 0, ganancias = 0, contCategoriaA = 0;
            for (int i = 0; i < cantFrutas; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    if (j==2)
                    {
                        sumPrecioCompra += int.Parse(frutas[i,j]);    
                    }
                    if (j==3)
                    {
                        sumPrecioVenta += int.Parse(frutas[i,j]);    
                    }
                    if (j==1)
                    {
                        if (frutas[i,j] == "a")
                        {
                            contCategoriaA++;
                        }
                    }     

                }
            }

            ganancias = sumPrecioVenta - sumPrecioCompra;
            System.Console.WriteLine(contCategoriaA);
            System.Console.WriteLine(ganancias); 



        }
    }
}
