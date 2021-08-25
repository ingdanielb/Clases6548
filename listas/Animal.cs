namespace listas
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int CantidadPatas { get; set; }

        public Animal(string nombre, string raza, int cantidadPatas)
        {
            Nombre = nombre;
            Raza = raza;
            CantidadPatas = cantidadPatas;
        }       
    }
}