namespace InterfacesMundoReal;

public interface IFuncionario
{
    // Declaración de las propiedades
    string Nombre { get; set; }
    string Apellidos { get; set; }

    void CotejarDocumentos();

}
