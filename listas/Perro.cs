using System;
using System.Collections.Generic;
using System.Linq;

namespace listas
{
    public class Perro : Animal
    {
        public bool Vacunado { get; set; }
        static List<Perro> perros = new List<Perro>();

        public Perro(string nombre, string raza, int cantidadPatas, bool vacunado) : base(nombre, raza, cantidadPatas)
        {
            this.Vacunado = vacunado;
        }
        public void infoPerro()
        {
            System.Console.WriteLine("Informacion del perro " + this.Nombre + "\n");
            System.Console.WriteLine("Nombre: " + this.Nombre);
            System.Console.WriteLine("Raza: " + this.Raza);
            System.Console.WriteLine("Cantidad de patas: " + this.CantidadPatas);
            System.Console.WriteLine("Vacunado: " + this.Vacunado);
        }

        public static void registrar()
        {
            System.Console.WriteLine("Ingresa el nombre del perro");
            string nombrePerro = Console.ReadLine();
            string razaPerro;
            int cantidadPatasPerro;
            bool isVacunado;

            if (perros.Count() > 0)
            {
                System.Console.WriteLine(perros.Count());
                foreach (var item in perros.ToList())
                {
                    if (item.Nombre.Equals(nombrePerro))
                    {
                        System.Console.WriteLine("Ya existe un registro");
                    }
                    else
                    {
                        System.Console.WriteLine("Ingresa la raza del perro");
                        razaPerro = Console.ReadLine();
                        System.Console.WriteLine("Ingresa la cantidad de patas");
                        cantidadPatasPerro = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ingresa true si el perro está vacunado, o false si no lo está");
                        isVacunado = bool.Parse(Console.ReadLine());

                        var perro = new Perro(nombrePerro, razaPerro, cantidadPatasPerro, isVacunado);
                        perros.Add(perro);
                        System.Console.WriteLine("El registro se agrego exitosamente \n");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Ingresa la raza del perro");
                razaPerro = Console.ReadLine();
                System.Console.WriteLine("Ingresa la cantidad de patas");
                cantidadPatasPerro = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Ingresa true si el perro está vacunado, o false si no lo está");
                isVacunado = bool.Parse(Console.ReadLine());

                var perro = new Perro(nombrePerro, razaPerro, cantidadPatasPerro, isVacunado);
                perros.Add(perro);
                System.Console.WriteLine("El registro se agrego exitosamente");
            }

        }

        public static void consultar()
        {
            System.Console.WriteLine("Ingresa el nombre del perro");
            string nombrePerro = Console.ReadLine();
            foreach (var item in perros)
            {
                if (nombrePerro == item.Nombre)
                {
                    item.infoPerro();
                }
                else
                {
                    System.Console.WriteLine("No hay un perro registrado con ese nombre");
                }
            }
        }

        public static void eliminar()
        {
            System.Console.WriteLine("Ingresa el nombre del perro");
            string nombrePerro = Console.ReadLine();

            int indice = 0;

            foreach (var item in perros)
            {
                if (nombrePerro == item.Nombre)
                {
                    indice = perros.IndexOf(item);
                }
            }
            perros.RemoveAt(indice);
        }

        public static void actualizar()
        {
            System.Console.WriteLine("Ingresa el nombre del perro");
            string nombrePerro = Console.ReadLine();

            foreach (var item in perros)
            {
                if (nombrePerro == item.Nombre)
                {
                    System.Console.WriteLine("Ingresa la raza del perro");
                    string razaPerro = Console.ReadLine();
                    System.Console.WriteLine("Ingresa la cantidad de patas");
                    int cantidadPatasPerro = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingresa true si el perro está vacunado, o false si no lo está");
                    bool isVacunado = bool.Parse(Console.ReadLine());

                    item.Raza = razaPerro;
                    item.CantidadPatas = cantidadPatasPerro;
                    item.Vacunado = isVacunado;
                    System.Console.WriteLine("El registro se actualizo exitosamente \n");
                }
            }

        }

        public static void menu()
        {
            System.Console.WriteLine("Menu \n1. Registrar Perro \n2. Actualizar Perro \n3. Eliminar Perro \n4. Consultar Perro \n5. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    registrar();
                    break;
                case 2:
                    actualizar();
                    break;
                case 3:
                    eliminar();
                    break;
                case 4:
                    consultar();
                    break;
                case 5:
                    System.Console.WriteLine("Salir"); ;
                    break;
                default:
                    System.Console.WriteLine("Ingresa una opcion valida");
                    break;
            }
        }
    }

}


