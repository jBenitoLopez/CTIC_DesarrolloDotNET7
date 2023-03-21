namespace Interfaces;
class Program
{
    static void Main(string[] args)
    {
        /*
        var alumno = new Alumno();
        alumno.Nombre = "Rubén";
        alumno.Apellidos = "Rubio";
        // alumno.MostrarNombre();
        MostrarPorConsolaIs(alumno);

        var profesor = new Profesor();
        profesor.Nombre = "Francisco";
        profesor.Apellidos = "Pérez";
        // profesor.MostrarNombre();
        MostrarPorConsolaIs(profesor);
        */

        Alumno alumno = new Alumno();
        alumno.Nombre = "Rubén";
        alumno.Apellidos = "Rubio";
        MostrarPorConsolaIs(alumno);

        Profesor profesor = new Profesor();
        profesor.Nombre = "Francisco";
        profesor.Apellidos = "Pérez";
        MostrarPorConsolaIs(profesor);

        Conserje conserje = new Conserje();
        conserje.Nombre = "test";
        MostrarPorConsolaIs(conserje);

    }

    private static void MostrarPorConsola(IContribuyente objeto)
    {
        Console.WriteLine(objeto.Nombre + " " + objeto.Apellidos);
    }

    //Versión con operador as
    private static void MostrarPorConsolaAs(object objeto)
    {
        IContribuyente contribuyente = objeto as IContribuyente;
        if (contribuyente != null)
        {
            Console.WriteLine(contribuyente.Nombre + " " + contribuyente.Apellidos);
        }
        else
        {
            Console.WriteLine("Función ejecutada");
        }
    }

    //Versión con operador is
    private static void MostrarPorConsolaIs(object objeto)
    {
        if (objeto is IContribuyente)
        {
            IContribuyente contribuyente = (IContribuyente)objeto;
            Console.WriteLine(contribuyente.Nombre + " " + contribuyente.Apellidos);
        }
        else
        {
            Console.WriteLine("Función ejecutada");
        }
    }


}

// Declaración del delegado del evento
// public delegate void DatosCambiadosEventHandler(string NombreProp, string ValorAnterior, string ValorNuevo);

