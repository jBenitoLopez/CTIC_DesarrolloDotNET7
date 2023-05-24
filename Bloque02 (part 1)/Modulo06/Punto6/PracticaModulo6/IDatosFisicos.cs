using System;
namespace PracticaModulo6;
public interface IDatosFisicos<TPeso, TAltura>
{
    public string Nombre { get; set; }
    public TPeso Peso
    { get; set; }
    public TAltura Altura { get; set; }


    void MostrarDatosFisicos();
}