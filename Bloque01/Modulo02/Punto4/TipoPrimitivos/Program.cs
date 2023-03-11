namespace TipoPrimitivos;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tipos Primitivos");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("1 byte");
        Console.WriteLine("byte min: " + byte.MinValue);
        Console.WriteLine("byte max: " + byte.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("1 byte");
        Console.WriteLine("sbyte min: " + sbyte.MinValue);
        Console.WriteLine("sbyte max: " + sbyte.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("2 byte");
        Console.WriteLine("short min: " + short.MinValue);
        Console.WriteLine("short max: " + short.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("2 byte");
        Console.WriteLine("ushort min: " + ushort.MinValue);
        Console.WriteLine("ushort max: " + ushort.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("4 byte");
        Console.WriteLine("int min: " + int.MinValue);
        Console.WriteLine("int max: " + int.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("4 byte");
        Console.WriteLine("uint min: " + uint.MinValue);
        Console.WriteLine("uint max: " + uint.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("8 byte");
        Console.WriteLine("long min: " + long.MinValue);
        Console.WriteLine("long max: " + long.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("8 byte");
        Console.WriteLine("ulong min: " + ulong.MinValue);
        Console.WriteLine("ulong max: " + ulong.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("16 byte - a partir de .NET 7 y C# 11");
        Console.WriteLine("Int128 min: " + Int128.MinValue);
        Console.WriteLine("Int128 max: " + Int128.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("16 byte - a partir de .NET 7 y C# 11");
        Console.WriteLine("UInt128 min: " + UInt128.MinValue);
        Console.WriteLine("UInt128 max: " + UInt128.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("char 2 bytes");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("1 byte");
        bool vBool = false;
        Console.WriteLine("bool values: " + vBool);
        vBool = true;
        Console.WriteLine("bool values: " + vBool);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("4 byte");
        Console.WriteLine("float min: " + float.MinValue);
        Console.WriteLine("float max: " + float.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("8 byte");
        Console.WriteLine("double min: " + double.MinValue);
        Console.WriteLine("double max: " + double.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("16 byte");
        Console.WriteLine("decimal min: " + decimal.MinValue);
        Console.WriteLine("decimal max: " + decimal.MaxValue);
        Console.WriteLine("--------------------------------");

        Console.WriteLine("La suma es: " + Sum(12, 8));
    }

    private static uint Sum(uint num1, uint num2)
    {
        return num1 + num2;
    }
}