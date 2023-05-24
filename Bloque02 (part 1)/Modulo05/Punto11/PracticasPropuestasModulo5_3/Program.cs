namespace PracticasPropuestasModulo5_3;
class Program
{
    /*
    Vamos a jugar con las interfaces y sus particularidades. 
    Para ello vamos a hacer un programa por partes e ir probando cosas:

    Crea una interfaz llamada IPajaro que tenga un método Volar() sin parámetros 
    y sin devolver nada, y otro método igual llamado Aletear().

    Crea una interfaz llamada IAvion que tenga también un método Volar() sin parámetros 
    y sin devolver nada.

    Ahora crea una nueva clase llamada Superman que como todo el mundo sabe puede ser 
    un pájaro o un avión, y que implemente ambas interfaces. 
    Define los métodos Volar y Aletear para esta clase y haz que simplemente muestren 
    algo por pantalla (por ejemplo "Volando!" y "Aleteando!").

    Crea una nueva instancia de la clase Superman (sup1) y haz que vuele y aletee. 
    Hasta aquí todo perfecto.

    Ahora define una variable sup2 y haz que contenga una referencia sup1 
    pero que solo se comporte como un avión. 
    Haz volar y aletear a nuestro Superman usando esta segunda referencia sup2. 
    ¿Ha funcionado todo bien o ha dado algún error? ¿Por qué?

    Ahora define una variable sup3 y haz que contenga una referencia sup1 
    pero que solo se comporte como un pájaro. 
    Haz volar y aletear a nuestro Superman usando esta segunda referencia sup2. 
    ¿Ha funcionado todo bien o ha dado algún error? ¿Por qué?

    Redefine la clase Superman para que el comportamiento de Volar sea diferente 
    según se esté tratando como un pájaro o como un avión (que muestre una frase 
    diferente según el caso). 
    ¿Cómo lo harías? 
    ¿Qué pasaría si intentas hacer volar a Superman sin primero hacer que se comporte 
    específicamente como un pájaro o como un avión?

    Haz que la clase Superman se comporte bien a la hora de volar tanto si se usa 
    directamente como si se usa como pájaro o como avión. 
    Que muestre por pantalla una cosa diferente en cada uno de los tres casos.
    */
    static void Main(string[] args)
    {
        System.Console.WriteLine("=== Sup 1 ===");
        Superman sup1 = new();
        sup1.Volar();
        // sup1.Aletear();

        System.Console.WriteLine("=== Sup 2 ===");
        IAvion sup2 = sup1;
        sup2.Volar();
        // sup2.Aletear();

        System.Console.WriteLine("=== Sup 3 ===");
        IPajaro sup3 = new Superman();
        sup3.Volar();

        System.Console.WriteLine("=== TEST ===");

        Dog spot = new Dog();
        PrintTypes(spot);
    }

    static void PrintTypes(Animal a)
    {
        Console.WriteLine(a.GetType() == typeof(Animal)); // false 
        Console.WriteLine(a is Animal);                   // true 
        Console.WriteLine(a.GetType() == typeof(Dog));    // true
        Console.WriteLine(a is Dog);                      // true 
    }

}


class Animal { }
class Dog : Animal { }

