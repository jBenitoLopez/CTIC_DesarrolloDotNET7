namespace ClasesParciales;

public class Alumno : Persona
{
    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

    public override bool ValidarInformacion()
    {
        return true;
    }
}