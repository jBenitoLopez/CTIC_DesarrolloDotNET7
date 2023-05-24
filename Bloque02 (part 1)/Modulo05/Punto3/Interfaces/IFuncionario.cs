namespace Interfaces;

public interface IFuncionario
{
    // Declaración de las propiedades
    string Nombre { get; set; }
    string Apellidos { get; set; }

    // Declaración de los indizadores
    string this[int index] { get; set; }
    IFuncionario this[string index] { get; }

    // Declaración de los métodos
    void MostrarNombre();
    string CotejarDocumentos();

    // Declaración de los eventos
    event DatosCambiadosEventHandler DatosCambiados;
}
