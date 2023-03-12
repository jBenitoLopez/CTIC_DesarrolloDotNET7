namespace demoIfSwitch;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Introduce un Numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 5 && numero < 10)
        {
            Console.WriteLine("El numero estan dentro del intervalo. :)");
        }
        else
        {
            Console.WriteLine("No esta dentro del intervalo!!! :(");
        }

        if (numero == 0)
        {
            Console.WriteLine("El numero es Cero.");
        }
        else
        {
            Console.WriteLine($"El Numero `{numero}` es {((numero % 2 == 0) ? "Par" : "Inpar")}");
        }

        System.Console.WriteLine("\n---------------------------------------------------------\n");

        switch (numero % 3)
        {
            case 0:
                System.Console.WriteLine("Es par");
                if(numero % 3 == 0 ) goto case 2;
                break;
            case 1:
                System.Console.WriteLine("Es in-par");
                break;
            case 2:
                System.Console.WriteLine("Es la tercera opcion");
                break;
            default:
                System.Console.WriteLine("No se lo que es...");
                break;
        }
        System.Console.WriteLine("\n---------------------------------------------------------\n");
    }
}
