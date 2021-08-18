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

        public void ladrar(){            
            System.Console.WriteLine($"{this.Nombre} esta ladrando ");
        }

        public void infoAnimal()
        {            
            System.Console.WriteLine("Cantidad colmillos: " + CantColmillos);
        }
    }
}