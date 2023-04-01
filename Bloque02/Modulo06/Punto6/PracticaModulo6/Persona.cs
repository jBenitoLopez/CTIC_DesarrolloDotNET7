namespace PracticaModulo6;
public class Persona : IDatosFisicos<decimal, decimal>
{

    public string Nombre { set; get; }
    public string Apellidos { set; get; }
    public decimal Peso { get; set; }
    public decimal Altura { get; set; }

    public Persona() { }
    public Persona(string nombre, string apellidos)
    {
        this.Nombre = nombre;
        this.Apellidos = apellidos;
    }

    public Persona(string nombre, decimal peso, decimal altura)
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