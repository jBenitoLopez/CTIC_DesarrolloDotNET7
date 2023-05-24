namespace InterfazIDisposable;

public class Persona : IDisposable
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

    // Variable empleada para controlar que sólo se llame una vez a Dispose y evitar ejecutar
    // código alguno si ya ha sido liberado
    bool disposed = false;

    // Destructor llamado por el GC al eliminar el objeto de memoria.
    ~Persona()
    {
        // Liberamos los recursos no manejados
        Dispose(false);
    }

    // Llamado explícitamente por el desarrollador mediante los métodos que veremos
    public void Dispose()
    {
        // Llamamos a Dispose para liberar los recursos mantenidos por la clase
        Dispose(true);
        // No es necesario que el GC llame al finalizador puesto que nos hemos encargado nosotros
        System.GC.SuppressFinalize(this);
    }

    // Aquí liberamos los recursos.
    // Se puede invocar desde el destructor pasando false, pues el destructor solo debe liberar recursos
    // no manejados, ya que al ser llamado por el GC, éste ya se encarga de los manejados
    // Si se invoca desde el método Dispose pasando true, liberaremos todos los objetos, sean manejados o no,
    // puesto que en este caso nos encargamos nosotros de todo en lugar del GC.
    protected virtual void Dispose(bool disposing)
    {
        // Si ya se ha ejecutado Dispose, cancelamos la ejecución
        if (disposed) return;

        // En caso contrario ejecutamos el código de liberación de recursos
        if (disposing)
        {
            // Liberar aquí los objetos manejados que implementen IDisposable llamando explícitamente a su método Dispose.
        }

        // Liberar aquí todos los recursos no manejados y al terminar lo marcamos como liberado
        disposed = true;
    }

    // Resto de métodos de la clase
    public void OtroMetodo()
    {
        // Si intentamos ejecutar un método, y el objeto ya ha llamado a Dispose(), lanzamos una excepción
        if (disposed) throw new ObjectDisposedException("Persona");

        // A continuación añadimos el código a ejecutar si no se ha llamado
    }
    #endregion Metodos
}
