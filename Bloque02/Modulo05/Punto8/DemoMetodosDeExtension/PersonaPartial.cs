namespace DemoMetodosDeExtension;

public abstract partial class Persona
{
    #region Propiedades
    private DateTime fechaNacimiento;

    public string Nombre { get; set; } = "Sin nombre";
    public string Apellidos { get; set; } = "Sin apellidos";
    public string Direccion { get; set; }

    public int Edad
    {
        get
        {
            return (int)(DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
        }
    }


    public DateTime FechaNacimiento
    {
        get { return fechaNacimiento; }
        set { fechaNacimiento = value; }
    }

    #endregion Propiedades
}