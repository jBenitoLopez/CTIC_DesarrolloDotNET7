using System.Text;
using System.Diagnostics;
using System;
namespace PracticasPropuestasModulo5;
class Program
{

    static void Main(string[] args)
    {
        Stopwatch timeMeasure = new Stopwatch();
        // Pixel[] matriz = new Pixel[800 * 600];
        Pixel[] matriz = new Pixel[1920 * 1080];

        timeMeasure.Start();
        LlenarMatriz(matriz);
        MostrarRegistrosSb(2000, matriz);
        timeMeasure.Stop();

        Console.WriteLine($"Tiempo de ejecución: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        // Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");
        // if (Stopwatch.IsHighResolution)
        //     Console.WriteLine("Alta precisión");
        // else
        //     Console.WriteLine("Baja precisión");

        /*  -- 800x600 CLASE --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 85,5553 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */
        /*  -- 800x600 STRUCT 1 (solo la clase Pixel) --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 55,7271 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */
        /*  -- 800x600 STRUCT 2 (clase Pixel y Rgb ) --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 30,5295 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */
        /*  -- 1920x1080 CLASE --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 366,5558 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */
        /*  -- 1920x1080 STRUCT 1 (solo la clase Pixel) --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 211,5922 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */
        /*  -- 1920x1080 STRUCT 2 (clase Pixel y Rgb )  --
            Posicion 801: x=1, Y=2
            Tiempo de ejecución: 95,3045 ms
            Precision: 1,000000E-007 segundos
            Alta precisión
        */

        // ================
        // 1920x1080 CLASE: Tiempo de ejecución: 605,2984 ms
        // 1920x1080 STRUCT 1 (solo la clase Pixel): Tiempo de ejecución: 570,7606 ms
        // 1920x1080 STRUCT 2 (clase Pixel y Rgb ): Tiempo de ejecución: 156,6104 ms [con string]
        // 1920x1080 STRUCT 2 (clase Pixel y Rgb ): Tiempo de ejecución: 109,7882 ms [con stringbuilder]
        // 1920x1080 CLASE: Tiempo de ejecución: 366,9134 ms [con stringbuilder]
        // ================
    }

    private static void MostrarRegistros(int aMostrar, Pixel[] matriz)
    {

        string cadena = "";
        Console.WriteLine("Por String");
        if (matriz.Length > aMostrar)
        {
            for (int i = 0; i < aMostrar; i++)
            {
                cadena += $"Posicion {i + 1}: {matriz[i].ToString()};\r\n";
            }

            Console.WriteLine(cadena);
        }
        else
        {
            Console.WriteLine("Quieres mostrar mas registros de los que hay en la matriz.");
        }


    }


    private static void MostrarRegistrosSb(int aMostrar, Pixel[] matriz)
    {

        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Por StringBuilder");

        if (matriz.Length > aMostrar)
        {
            for (int i = 0; i < aMostrar; i++)
            {

                sb.Append($"Posicion {i + 1}: {matriz[i].ToString()};\r\n");
            }

            Console.WriteLine(sb.ToString());
        }
        else
        {
            Console.WriteLine("Quieres mostrar mas registros de los que hay en la matriz.");
        }
    }

    static void LlenarMatriz(Pixel[] matriz)
    {


        // matriz[0, 0] = new Pixel(10, 100, new Rgb(5, 15, 25));
        // matriz[0, 0] = new Pixel(10, 100, new Rgb { R = 8, G = 16, B = 32 });

        for (int i = 0, x = 1, y = 1; i < matriz.Length; i++, x++)
        {
            // if (i != 0 && i % 800 == 0)
            if (i != 0 && i % 1920 == 0)
            {
                x = 1;
                y++;
            }

            matriz[i] = new Pixel(x, y, new Rgb());
        }

        System.Console.WriteLine($"Posicion 801: x={matriz[800].X}, Y={matriz[800].Y}");
    }
}
