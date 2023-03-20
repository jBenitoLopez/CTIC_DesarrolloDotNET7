namespace clases_y_estructuras;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- CLASS --");
        PuntoClass puntoClass = new(5, 10);
        Console.WriteLine($"Antes: {puntoClass}");
        SumaCoordenadasClass(puntoClass, 5);
        Console.WriteLine($"Despues: {puntoClass}");

        System.Console.WriteLine("--- STRUCT --");
        PuntoStruct puntoStruct = new(5, 10);
        Console.WriteLine($"Antes: {puntoStruct}");
        SumaCoordenadasStruct(puntoStruct, 5);
        Console.WriteLine($"Despues: {puntoStruct}");

    }

    public static void SumaCoordenadasClass(PuntoClass p, int incremento)
    {
        p.x += incremento;
        p.y += incremento;
    }

    public static void SumaCoordenadasStruct(PuntoStruct p, int incremento)
    {
        p.x += incremento;
        p.y += incremento;
    }
}


public class PuntoClass
{
    public int x, y;
    public PuntoClass(int X, int Y)
    {
        this.x = X;
        this.y = Y;
    }

    public override string ToString()
    {
        return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
    }
}

public struct PuntoStruct
{
    public int x, y;
    public PuntoStruct(int X, int Y)
    {
        this.x = X;
        this.y = Y;
    }

    public override string ToString()
    {
        return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
    }
}