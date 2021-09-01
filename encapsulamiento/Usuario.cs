

using System;

namespace encapsulamiento
{
    public class Usuario
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private string Clave { get; set; }


        public void infoUsuario()
        {
            Console.WriteLine(Nombre);
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }


        public int GetEdad() => Edad;
        public void SetEdad(int edad)
        {
            if (edad < 16)
            {
                Edad = 0;
            }
            else
            {
                Edad = edad;
            }

        }
    }
}