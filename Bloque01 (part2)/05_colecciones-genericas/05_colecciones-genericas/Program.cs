// See https://aka.ms/new-console-template for more information

using _05_colecciones_genericas;

Console.WriteLine("DEMO: Empleando distintos tipos de colecciones: de tipo genérico\n");

Console.WriteLine("\n****************** List ******************");
List<int> list = new List<int>()
{
    1, 2, 3, 4
};
list.Add(11);
list.Add(22);
list.Add(33);
list.Insert(4, 8);

list.Remove(3);
list.RemoveAt(5);

foreach (var item in list)
{
    Console.WriteLine($"item is {item}");
}

Console.WriteLine("\n****************** Dictionary ******************");

Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

alumnos.Add(101, new Alumno() {Referencia = 101, Nombre = "Pepito", Apellidos="Grillo"});
alumnos.Add(102, new Alumno() {Referencia = 102, Nombre = "Manolo", Apellidos="Panda"});
alumnos.Add(103, new Alumno() {Referencia = 103, Nombre = "Jose", Apellidos= "Pardo" });

Console.WriteLine($"Alumno 102 se llama {alumnos[102].Nombre} {alumnos[102].Apellidos}");


Console.WriteLine("\n****************** Queue ******************");

Queue<Alumno> alumnosQueue = new Queue<Alumno>();

alumnosQueue.Enqueue(new Alumno() { Referencia = 101, Nombre = "Pepito", Apellidos = "Grillo" });
alumnosQueue.Enqueue(new Alumno() { Referencia = 102, Nombre = "Manolo", Apellidos = "Panda" });
alumnosQueue.Enqueue(new Alumno() { Referencia = 103, Nombre = "Jose", Apellidos = "Pardo" });

var alumQ = alumnosQueue.Dequeue();

Console.WriteLine($"Alumno Dequeue se llama {alumQ.Nombre} {alumQ.Apellidos}");


Console.WriteLine("\n****************** Stack ******************");

Stack<Alumno> alumnosStack = new Stack<Alumno>();
alumnosStack.Push(new Alumno() { Referencia = 101, Nombre = "Pepito", Apellidos = "Grillo" });
alumnosStack.Push(new Alumno() { Referencia = 102, Nombre = "Manolo", Apellidos = "Panda" });
alumnosStack.Push(new Alumno() { Referencia = 103, Nombre = "Jose", Apellidos = "Pardo" });

var alumS = alumnosStack.Pop();

Console.WriteLine($"Alumno Pop se llama {alumS.Nombre} {alumS.Apellidos}");

SortedList<int, string> frutas = new SortedList<int, string>() {
    { 6, "Naranja" },
    { 2, "Manzana"},
    { 4, "Pera"},
};

frutas.Add(3, "Platano");

foreach (var item in frutas)
{
    Console.WriteLine($"{item.Value} es muy bueno, y tiene el ID:{item.Key}");
}