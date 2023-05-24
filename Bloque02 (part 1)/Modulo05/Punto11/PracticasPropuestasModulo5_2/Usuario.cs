namespace PracticasPropuestasModulo5_2;

[Flags()]
public enum TipoUsuario
{
    Ninguno = 0,
    Lector = 1,             // solo puede leer los informes
    OperadorInformes = 2,   // puede publicar nuevos informes
    GestorUsuarios = 4,     // puede definir, editar y borrar usuarios del sistema de informes
    Administrador = 8 | OperadorInformes | GestorUsuarios,      // tiene las facultades de los dos anteriores y además puede gestionar otros parámetros de configuración
}
public class Usuario
{

    public string Nombre { get; set; }
    public TipoUsuario Tipo { get; set; }
}
