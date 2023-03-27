namespace CoincidenciaDeModelos;

public class Persona
{

    #region Constructores

    public Persona()
    {
        Nombre = "Sin nombre";
        Apellidos = "Sin apellidos";
        this.fechaNacimiento = DateTime.Today;
    }

    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }


    public Persona(string nombre, string apellidos, DateTime fechaNacimento) : this(nombre, apellidos)
    {
        this.fechaNacimiento = fechaNacimento;
    }

    public virtual void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y tiene {Edad} años.");
    }

    #endregion Constructores

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

    #region Metodos

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Fecha Naciemento: {fechaNacimiento}
        Edad: {Edad}
        Dirección: {Direccion}
        ";
    }
    #endregion Metodos
}
