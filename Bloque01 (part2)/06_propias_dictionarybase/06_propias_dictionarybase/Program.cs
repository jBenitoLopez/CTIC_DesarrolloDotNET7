using _06_propias_dictionarybase;
using System.Collections;

Console.WriteLine("DEMO: Creando nuestras propias colecciones: DictionaryBase");


ColeccionProfesores tabla = new ColeccionProfesores();
tabla.Add("Cálculo", new Profesor() { Nombre = "Pepito", Apellidos = "Grillo" });
tabla.Add("Ingles", new Profesor() { Nombre = "Manolo", Apellidos = "Pinto" });
tabla.Add("Robótica", new Profesor() { Nombre = "Carlos", Apellidos = "Mallas" });
tabla.Add("Electrónica", new Profesor() { Nombre = "Pedro", Apellidos = "Saltos" });
tabla.Add("Programación", new Profesor() { Nombre = "Juan", Apellidos = "Artista" });

tabla["Robótica"].Nombre = "Felipe";
tabla["Robótica"].Apellidos = "Gavilan";
Console.WriteLine($"*** MostrarNombre:");
tabla["Robótica"].MostrarNombre();

Console.WriteLine();

foreach (DictionaryEntry profesor in tabla)
{
    Console.WriteLine($"{profesor.Key} => Profesor {((Profesor)profesor.Value).Nombre} {((Profesor)profesor.Value).Apellidos} esta presente.");
}

Console.WriteLine("");