namespace Registros;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Registro - Record");
        var persona1 = new Persona("Rubén", "Rubio");
        var persona2 = persona1;
        var persona3 = new Persona("Rubén", "Rubio");
        var persona4 = new Persona("Rubén", "R.");

        Console.WriteLine($"Referencia: persona1 = persona2 {ReferenceEquals(persona1, persona2)}");
        Console.WriteLine($"Valor: persona1 = persona2 {persona1.Equals(persona2)}");
        Console.WriteLine($"Referencia: persona1 = persona3 {ReferenceEquals(persona1, persona3)}");
        Console.WriteLine($"Valor: persona1 = persona3 {persona1.Equals(persona3)}");
        Console.WriteLine($"Referencia: persona1 = persona4 {ReferenceEquals(persona1, persona4)}");
        Console.WriteLine($"Valor: persona1 = persona4 {persona1.Equals(persona4)}");


        Console.WriteLine("=== toString ===");
        var persona = new Persona("Rubén", "Rubio");
        Console.WriteLine(persona);

        Console.WriteLine("=== Instanciación mediante expresiones con with ===");
        var persona11 = new Persona("Rubén", "Rubio");
        var persona12 = persona11 with { Nombre = "Fernando" };

        Console.WriteLine($"Persona 11: {persona11}");
        Console.WriteLine($"Persona 12: {persona12}");


        Console.WriteLine("=== Registros por valor (record struct, C# 10+) ===");

        var objTestStruct = new PersonaStruct("Rubén", "Rubio");
        var objTestClass = new PersonaClass("Rubén", "Rubio");

        Console.WriteLine(objTestStruct);
        Console.WriteLine(objTestClass);



    }
}
