namespace _06_propias_collectionbase
{
    interface IContribuyente<T>
        where T : struct
    {
        T Referencia { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}