namespace linq
{
    public class Raza
    {
        public int Id { get; set; }
        public string NombreRaza { get; set; }

        public Raza(int id, string nombreRaza)
        {
            Id = id;
            NombreRaza = nombreRaza;
        }
    }
}