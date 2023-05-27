using System.Collections;
using System.Reflection.PortableExecutable;

Console.WriteLine("\n\n******************ArrayList******************");

ArrayList arrList = new ArrayList();
arrList.Add(11);
arrList.Add(22);
arrList.Add(33);
arrList.Insert(0, 44);
arrList.Add(55);

ArrayList frutas = new ArrayList() { 
    "Naranja",
    "Manzana",
    "Pera"
};
frutas.Add("Platano");


//Console.WriteLine("Count: " + frutas.Count);
//Console.WriteLine("Capacity: " + frutas.Capacity);

foreach (Object fruta in frutas)
{
    string f = (string)fruta;
    //Console.WriteLine(f);
}
Console.WriteLine("******************END******************");


Console.WriteLine("\n\n******************Hashtable******************");
Hashtable hashNombres = new Hashtable();

hashNombres.Add("REF001", "Roberto Torrez");
hashNombres.Add("REF002", "Maria Sanz");
hashNombres.Add("REF003", "Pedro Barbero");

Console.WriteLine("Count: " + hashNombres.Count);
Console.WriteLine("******************Keys******************");

foreach (var key in hashNombres.Keys)
{
    //Console.Write(key + ", ");
}

Console.WriteLine("\n******************Key/value******************");

foreach (DictionaryEntry item in hashNombres)
{
    string key = (string)item.Key;
    string value = (string)item.Value;

    //Console.WriteLine($"Key: {key}, Value: {value}");
}
Console.WriteLine("\n******************Existe el Key/value xx?******************");
Console.WriteLine("Existe el valor `Maria Sanz` ? " +  hashNombres.ContainsValue("Maria Sanz"));
Console.WriteLine("\n******************Accecer al Key xx?******************");
Console.WriteLine( $"El valor de `REF003` es {hashNombres["REF003"]}" );
Console.WriteLine("******************END******************");

Console.WriteLine("\n\n******************Queue/Stack******************");

Queue cola = new Queue();
Stack pila = new Stack();

for (int i = 0; i < 10; i++)
{
    cola.Enqueue(i);
    pila.Push(i);
}

Console.WriteLine($"\nObtener elementos de la cola (FIFO)");
while (cola.Count > 0)
{
    if((int)cola.Peek() % 2 == 0)
    {
        Console.Write("Es Par: ");
    }

    Console.WriteLine(cola.Dequeue());
}

Console.WriteLine($"\nObtener elementos de la pila (LIFO)");
while (pila.Count > 0)
{
    if ((int)pila.Peek() % 2 == 0)
    {
        Console.Write("Es Par: ");
    }

    Console.WriteLine(pila.Pop());
}

Console.WriteLine("******************END******************");