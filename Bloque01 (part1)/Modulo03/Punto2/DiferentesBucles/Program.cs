namespace DiferentesBucles;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n----- WHILE - Fibonacci ----");
        int numerosTotalAMostrar = 10;

        long num1 = 0;
        long num2 = 1;

        Console.WriteLine($"{num1}");
        Console.WriteLine($"{num2}");

        while (numerosTotalAMostrar-- > 0)
        {
            long sum = num1 + num2;
            num1 = num2;
            num2 = sum;

            Console.WriteLine($"{num2}");
        }

        Console.WriteLine("\n----- DO WHILE - Fibonacci ----");
        num1 = 0;
        num2 = 1;
        numerosTotalAMostrar = 10;
        do
        {
            long sum = num1 + num2;
            num1 = num2;
            num2 = sum;

            Console.WriteLine($"{num2}");
        } while (--numerosTotalAMostrar > 0);


        Console.WriteLine("\n----- FOR - Fibonacci ----");
        num1 = 0;
        num2 = 1;
        numerosTotalAMostrar = 10;
        
        for (int i = numerosTotalAMostrar; i > 0; i--)
        {
            long sum = num1 + num2;
            num1 = num2;
            num2 = sum;

            Console.WriteLine($"{num2}");
        }



    }
}
