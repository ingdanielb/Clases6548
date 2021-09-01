using System;

namespace encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            user.SetNombre("Pepe");
            user.SetEdad(17);
            //user.Clave = "asd123";

            System.Console.WriteLine(user.GetNombre());
            System.Console.WriteLine(user.GetEdad());

        }
    }
}
