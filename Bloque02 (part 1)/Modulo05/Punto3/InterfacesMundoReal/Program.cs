namespace InterfacesMundoReal;
class Program
{
    static void Main(string[] args)
    {
        Alumno alumno = new();
        alumno.Nombre = "Alumno1";
        alumno.Apellidos = "Apellidos Uno";
        alumno.MostrarNombre();
        // alumno.PagarImpuestos();
        // MostrarDatos2(alumno);


        Profesor profesor = new();
        profesor.Nombre = "profesor1";
        profesor.Apellidos = "Apellidos Uno";
        profesor.MostrarNombre();
        // profesor.PagarImpuestos();
        profesor.CotejarDocumentos();
        MostrarDatos2(profesor);

        Persona persona = new();
        persona.Nombre = "persona1";
        persona.Apellidos = "Apellidos Uno";
        persona.MostrarNombre();
        // MostrarDatos(persona);
    }

    public static void MostrarDatos(IContribuyente data)
    {
        System.Console.WriteLine($"Contribuyente => Nombre: {data.Nombre}, Apellidos: {data.Apellidos}");
        data.PagarImpuestos();
    }

    public static void MostrarDatos2(IFuncionario data)
    {
        System.Console.WriteLine($"Funcionario => Nombre: {data.Nombre}, Apellidos: {data.Apellidos}");
    }
}

