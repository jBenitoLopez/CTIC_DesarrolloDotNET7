namespace AppConsole;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(string.Format("argument {0}: {1}", i + 1, args[i]));
        }

        Console.Write("Escribe algo: ");
        string texto = Console.ReadLine() + "";
        Console.WriteLine(texto.ToUpper());

        Console.ReadLine();
    }
}
