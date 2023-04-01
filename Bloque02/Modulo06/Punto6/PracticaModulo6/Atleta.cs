namespace PracticaModulo6;
public class Atleta : IDatosFisicos<int, int>
{
    public string Nombre { get; set; }
    public int Peso { get; set; }
    public int Altura { get; set; }

    public void MostrarDatosFisicos()
    {

    }
}