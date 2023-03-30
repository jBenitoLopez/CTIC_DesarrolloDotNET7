namespace DeconstructoresYDescartes
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public void Deconstruct(out string nombre, out string apellido)
        {
            nombre = Nombre;
            apellido = Apellidos;
        }
    }

}