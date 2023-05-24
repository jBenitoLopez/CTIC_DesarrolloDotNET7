namespace PracticaModulo6;
public class Usuario : IDatosFisicos<int, int>
{
    public string Nombre { get; set; }
    public int Peso { get; set; }
    public int Altura { get; set; }

    public Usuario(string nombre, int peso, int altura)
    {
        this.Nombre = nombre;
        this.Peso = peso;
        this.Altura = altura;
    }
    public void MostrarDatosFisicos()
    {
        Console.WriteLine($"{Nombre} pesa {Peso} kilos y mide {Altura} metros.");
    }
}
