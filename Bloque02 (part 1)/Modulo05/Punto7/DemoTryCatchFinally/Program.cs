namespace DemoTryCatchFinally;
class Program
{
    static void Main(string[] args)
    {

        try
        {

            System.Console.Write("Introduce el dividendo: ");
            decimal numero1 = decimal.Parse(Console.ReadLine());
            System.Console.Write("Introduce el divisor: ");
            decimal numero2 = decimal.Parse(Console.ReadLine());

            MostrarDivision(numero1, numero2);
        }
        catch (System.DivideByZeroException err)
        {
            System.Console.WriteLine("Imposible dividir entre cero. {0}", err.Message);
        }
        catch (System.Exception err)
        {
            System.Console.WriteLine("Error generico: {0}", err.Message);
        }
        finally
        {
            System.Console.WriteLine("PROGRAMA FINALIZADO");
        }

    }

    private static void MostrarDivision(decimal numero1, decimal numero2)
    {
        if (numero1 > 1000)
        {
            throw new Exception("Número 1 no puede ser mayour que 1000");
        }

        if (numero2 > 1000)
        {
            throw new Exception("Número 2 no puede ser mayour que 1000");
        }


        try
        {
            System.Console.WriteLine($"El resultado de la división: {numero1 / numero2}");
        }
        catch (System.DivideByZeroException) when (numero1 > 10)
        {
            System.Console.WriteLine("Error de división por 0 anidado, con numero 1 mayor que 10");
            throw;
        }
        catch (System.DivideByZeroException)
        {
            System.Console.WriteLine("Error de división por 0 anidado");
        }

    }
}
