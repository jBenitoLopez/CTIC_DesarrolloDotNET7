namespace Registros;
// Declaración mediante registros posicionales
// public record Persona(string Nombre, string Apellidos);

// constructores adicionale
public record Persona(string Nombre, string Apellidos)
{
    public Persona(string Nombre) : this(Nombre, "") { }
};

// Sintáxis con C# 9 (sigue siendo válida)
public record PersonaRecord(string Nombre, string Apellidos); // Registros por referencia

// Sintáxis con C# 10
public record class PersonaClass2(string Nombre, string Apellidos); // Para registros por referencia
public record struct PersonaStruct2(string Nombre, string Apellidos); // Para registros por valor asimilables a estructuras
readonly record struct PersonaStruct3(string Nombre, string Apellidos);

record struct PersonaStruct(string Nombre, string Apellidos);
record class PersonaClass(string Nombre, string Apellidos);