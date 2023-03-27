namespace DemoMetodosDeExtension;

public abstract partial class Persona
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

    public abstract bool ValidarInformacion();


    #endregion Constructores

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
