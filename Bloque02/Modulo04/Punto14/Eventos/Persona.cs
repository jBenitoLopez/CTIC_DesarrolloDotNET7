namespace Eventos;

// public delegate void DatosCambiadosEventHandler(string campo, string valorAnterior, string valorNuevo);

public class Persona
{

    // public event DatosCambiadosEventHandler OnChange;
    public event EventHandler<DemoEventArgs> OnChange;

    #region Propiedades
    public DateTime FechaNacimiento { get; set; }
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (nombre != value)
            {
                // if (OnChange != null) OnChange("Nombre", nombre, value); ;
                // OnChange?.Invoke();

                // if (OnChange != null) OnChange(this, new EventArgs());
                if (OnChange != null) OnChange(this, new DemoEventArgs() { Campo = "Nombre", ValorAnterior = nombre, ValorNuevo = value });


            }
            nombre = value;
        }
    }

    private string apellidos;
    public string Apellidos
    {
        get { return apellidos; }
        set
        {
            if (apellidos != value)
            {
                //if(OnChange != null) OnChange();
                // OnChange?.Invoke("Apellidos", apellidos, value);

                // if (OnChange != null) OnChange(this, new EventArgs());
                if (OnChange != null) OnChange(this, new DemoEventArgs() { Campo = "Apellidos", ValorAnterior = apellidos, ValorNuevo = value });
            }
            apellidos = value;
        }
    }

    public string Direccion { get; set; }

    public int Edad
    {
        get
        {
            return (int)(DateTime.Today.Subtract(FechaNacimiento).Days / 365.25);
        }
    }
    #endregion Propiedades

    #region Constructores

    public Persona()
    {
        Nombre = "Sin nombre";
        Apellidos = "Sin apellidos";
        FechaNacimiento = DateTime.Today;
    }

    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }


    public Persona(string nombre, string apellidos, DateTime fechaNacimento) : this(nombre, apellidos)
    {
        FechaNacimiento = fechaNacimento;
    }

    public virtual void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y tiene {Edad} años.");
    }

    #endregion Constructores

    #region Metodos

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Fecha Naciemento: {FechaNacimiento}
        Edad: {Edad}
        Dirección: {Direccion}
        ";
    }

    #endregion Metodos
}


public class DemoEventArgs : EventArgs
{
    public string Campo { get; set; }
    public string ValorAnterior { get; set; }
    public string ValorNuevo { get; set; }
}