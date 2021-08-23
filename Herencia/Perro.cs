namespace Herencia
{
    public class Perro : Animal
    {
        int CantColmillos { get; set; }
        public Perro(string nombre, int edad, int cantidadPatas, string color, int cantColmillos)
        : base(nombre, edad, cantidadPatas, color)
        {
            CantColmillos = cantColmillos;
        }

        public void ladrar()
        {
            System.Console.WriteLine($"{this.Nombre} esta ladrando ");
        }

        public void infoAnimalPerro()
        {
            System.Console.WriteLine("** Informacion del perro " + Nombre + "**");
            base.infoAnimal();
            System.Console.WriteLine("Cantidad colmillos = " + CantColmillos);
        }

        public override void suscripcionVeterinaria(bool suscripcion)
        {
            if (suscripcion)
            {
                System.Console.WriteLine("Suscripcion activa");
            }
            else
            {
                System.Console.WriteLine("Suscripcion inactiva");
            }
        }

        public void correr()
        {
            System.Console.WriteLine("El perro esta corriendo");
        }

        public void correr(string nombrePerro)
        {
            System.Console.WriteLine($"El perrro {nombrePerro} esta corriendo");
        }

        public void correr(string nombrePerro, int velocidad)
        {
            System.Console.WriteLine($"El perrro {nombrePerro} esta corriendo corriendo a una velocidad de {velocidad}");
        }
    }
}