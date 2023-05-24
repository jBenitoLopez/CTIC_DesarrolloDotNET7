namespace DemoClasesGenericas;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Alumno alumno1 = new()
        {
            Nombre = "Pepito",
            Apellidos = "Grillo",
            Referencia = 22
        };

        Alumno alumno2 = new()
        {
            Nombre = "Pepito",
            Apellidos = "Grillo"
        };

        // AccionPersona<Alumno, int> accion = new();
        // accion.Persona = alumno1;
        // accion.Comparar(alumno2);

        Profesor profesor1 = new()
        {
            Nombre = "Pepito",
            Apellidos = "Grillo",
            Referencia = "id001"
        };

        Profesor profesor2 = new()
        {
            Nombre = "Pepito",
            Apellidos = "Grillo",
            Referencia = "id001"
        };

        // AccionPersona2<Alumno, int> accion2 = new();
        // accion2.Persona = profesor1;
        // accion2.Comparar(profesor2);

        System.Console.WriteLine($"AccionPersona2: {AccionPersona2.Comparar<int>(5, 6)}");
    }
}

public static class AccionPersona2
{
    public static bool Comparar<T>(T numero1, T numero2)
        where T : struct
    {
        return numero1.Equals(numero2);
    }
}

public class AccionPersona<T, TReferencia>
    where T : IContribuyente<TReferencia>
    where TReferencia : struct
{
    public T Persona { get; set; }
    public TReferencia Referencia { get; set; }


    public void Comparar(T OtraPersona)
    {

        System.Console.WriteLine($"Son Alumnos iguales: {Persona.Nombre == OtraPersona.Nombre && Persona.Apellidos == OtraPersona.Apellidos}");
        System.Console.WriteLine($"La referencia: {Persona.Referencia}");

        // if (OtraPersona is Alumno)
        // {
        //     var alumno1 = Persona as Alumno;
        //     var alumno2 = OtraPersona as Alumno;
        //     System.Console.WriteLine($"Son Alumnos iguales: {alumno1.Nombre == alumno2.Nombre && alumno1.Apellidos == alumno2.Apellidos}");
        // }

        // if (OtraPersona is Profesor)
        // {
        //     var profesor1 = Persona as Profesor;
        //     var profesor2 = OtraPersona as Profesor;
        //     System.Console.WriteLine($"Son profesores iguales: {profesor1.Nombre == profesor2.Nombre && profesor1.Apellidos == profesor2.Apellidos}");
        // }

        // if (OtraPersona is Persona)
        // {
        //     var persona1 = Persona as Persona;
        //     var persona2 = OtraPersona as Persona;
        //     System.Console.WriteLine($"Son personas iguales: {persona1.Nombre == persona2.Nombre && persona1.Apellidos == persona2.Apellidos}");
        // }


        Console.WriteLine("Equal: " + Persona.Equals(OtraPersona));
    }
}
