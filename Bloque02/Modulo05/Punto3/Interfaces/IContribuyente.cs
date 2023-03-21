namespace Interfaces;

public interface IContribuyente
{
    string Nombre { get; set; }
    string Apellidos { get; set; }

    void MostrarNombre();

    string this[int index] { get; set; }
    IContribuyente this[string index] { get; }
}