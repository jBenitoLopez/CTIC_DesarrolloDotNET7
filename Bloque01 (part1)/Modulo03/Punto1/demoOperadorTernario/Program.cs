namespace demoOperadorTernario;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dame un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string resultado = numero >= 0 ? $"El Numero {numero} es positivo" : "Numero es negativo";
        System.Console.WriteLine(resultado);

    }
}
