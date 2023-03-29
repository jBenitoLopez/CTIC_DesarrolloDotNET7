namespace DemoClasesGenericas
{
    interface IFuncionario
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void CotejarDocumentos();
    }
}
