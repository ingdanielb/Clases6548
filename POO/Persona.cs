namespace POO
{
    public class Persona
    {   //Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }
        public int Salario { get; set; }


        //Metodos
        public void infoPersona(){
            System.Console.WriteLine("Nombre: " + Nombre);
            System.Console.WriteLine("Apellido: " + Apellido);
            System.Console.WriteLine("Edad: " + Edad);
            System.Console.WriteLine("Estatura: " + Estatura);
            System.Console.WriteLine("Peso: " + Peso);
            System.Console.WriteLine("Salario: " + Salario);
        }
        
    }
}