namespace TrabajandoConCadenas;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---STRING-LENGTH---");
        string cadena1 = "Esto es un ejemplo";
        string cadena2 = " Esto es un ejemplo ";
        Console.WriteLine(cadena1.Length);
        Console.WriteLine(cadena2.Length);

        Console.WriteLine("---TRIM---");
        string cadena3 = " Esto es un ejemplo ";
        Console.WriteLine(cadena3.TrimEnd().Length);
        Console.WriteLine(cadena3.TrimStart().Length);
        Console.WriteLine(cadena3.Trim().Length);


        Console.WriteLine("---SPLIT---");
        string cadena4 = "Uno Dos Tres Cuatro Cinco Seis Siete";
        var palabras = cadena4.Split(' ');
        foreach (var palabra in palabras)
        {
            Console.WriteLine(palabra);
        }

        Console.WriteLine("---JOIN---");
        string[] numeros = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete" };
        string unidos = String.Join(", ", numeros);
        Console.WriteLine(unidos);

        Console.WriteLine("---SUBSTRING---");
        string cadena5 = "Uno Dos Tres Cuatro Cinco Seis Siete";
        Console.WriteLine(cadena5.Substring(4));
        Console.WriteLine(cadena5.Substring(4, 8));
        Console.WriteLine(cadena5.Replace('o', 'Z'));

        Console.WriteLine("---REMOVE---");
        Console.WriteLine(cadena5.Remove(4, 9));

        Console.WriteLine("---INDEXOF---");
        int posicion = cadena5.IndexOf("Dos");
        Console.WriteLine(cadena5.Substring(0, posicion - 1));


    }
}
