

using _06_propias_collectionbase;

Console.WriteLine("Hello, World!");


var lista = new ColeccionAlumnos();

lista.Add(new Alumno()
{
    Nombre= "Rubén",
    Apellidos = "Rubio"
});

lista.Insert(0,new Alumno()
{
    Nombre = "Pepito",
    Apellidos = "Grillo"
});

lista.Insert(1, new Alumno()
{
    Nombre = "Manolo",
    Apellidos = "Macho"
});

//lista.Remove(new Alumno()
//{
//    Nombre = "Manolo",
//    Apellidos = "Macho"
//});

lista.Sort();

foreach (Alumno item in lista)
{
    Console.WriteLine($"Alumno: {item.Nombre} {item.Apellidos}");
}

var alumno = lista[0];
Console.WriteLine($"El alumno en la posicion 0 es {alumno.Nombre} {alumno.Apellidos}");
Console.WriteLine("hola");