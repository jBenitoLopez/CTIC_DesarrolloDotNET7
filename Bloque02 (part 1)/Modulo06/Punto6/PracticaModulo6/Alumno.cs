namespace PracticaModulo6;
public class Alumno : Persona
{
    public string[] ListaAsignaturas { get; set; } = { };
    public string Aula { get; set; } = "";

    public Alumno(string Nombre, string Apellidos) : base(Nombre, Apellidos)
    {
    }

    public void PagarImpuestos()
    {
        Console.WriteLine("Pagando impuestos");
    }

    public int CompareTo(object obj)
    {
        if (obj is Alumno)
        {
            Alumno alumno = (Alumno)obj;
            return string.Compare(this.Apellidos + ", " + this.Nombre, alumno.Apellidos + ", " + alumno.Nombre);
        }
        else
        {
            return 0;
        }
    }

}
