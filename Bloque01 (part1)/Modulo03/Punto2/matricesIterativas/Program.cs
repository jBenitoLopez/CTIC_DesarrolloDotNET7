namespace matricesIterativas;
class Program
{
    static void Main(string[] args)
    {
        int[,] arrayEnteros = { { 5, 4 }, { 78, 5 }, { 12, 6 } };

        System.Console.WriteLine($"\n----- while ----");

        int row = 0;
        while (row < arrayEnteros.GetLength(0))
        {
            int col = 0;
            while (col < arrayEnteros.GetLength(1))
            {
                Console.Write($"{arrayEnteros[row, col]}, ");
                col++;
            }
            System.Console.WriteLine("");
            row++;
        }

        System.Console.WriteLine($"\n----- for ----");
        for (int r = 0; r < arrayEnteros.GetLength(0); r++)
        {
            for (int c = 0; c < arrayEnteros.GetLength(1); c++)
            {
                Console.Write($"{arrayEnteros[r, c]}, ");
            }
            System.Console.WriteLine("");
        }

        System.Console.WriteLine($"\n----- foreach ----");
        foreach (var item in arrayEnteros)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine($"\n----- ----- ----- ----- ----");
        System.Console.WriteLine($"\n----- JAGGED ARRAY ----");

        int[][] jaggedEnteros = new int[3][];
        jaggedEnteros[0] = new int[3] { 1, 2, 3 };
        jaggedEnteros[1] = new int[2] { 4, 5 };
        jaggedEnteros[2] = new int[4] { 6, 7, 8, 9 };

        System.Console.WriteLine($"\n----- while ----");

        row = 0;
        while (row < jaggedEnteros.Length)
        {
            int col = 0;
            while (col < jaggedEnteros[row].Length)
            {
                Console.WriteLine($"({row},{col}) = {jaggedEnteros[row][col]}");
                col++;
            }
            System.Console.WriteLine("");
            row++;
        }

        System.Console.WriteLine($"\n----- for ----");
        for (int r = 0; r < jaggedEnteros.Length; r++)
        {
            for (int c = 0; c < jaggedEnteros[r].Length; c++)
            {
                Console.WriteLine($"({r},{c}) = {jaggedEnteros[r][c]}");
            }
            System.Console.WriteLine("");
        }

        System.Console.WriteLine($"\n----- foreach ----");
        foreach (var internArray in jaggedEnteros)
        {
           foreach (var item in internArray)
           {
            Console.WriteLine($"{item}");
           }
           System.Console.WriteLine("");
        }


    }
}
