namespace PracticasPropuestasModulo5_4;
class Program
{
    /*
    En un proyecto nuevo de consola define una clase especial llamada ExtensionesString 
    que va a servir para albergar varios métodos de extensión para la clase que 
    representa cadenas en .NET. 

    Dentro de ella define cuatro métodos extensores:
        Invertir: debe darle la vuelta a la cadena
        EstaVacia: devolverá true si la cadena está vacía o es nula o false en caso contrario.
        Right: devolverá el número de caracteres de la cadena indicado como parámetro, 
               tomándolos desde la derecha de la misma.
        Left: devolverá el número de caracteres de la cadena indicado como parámetro, 
              tomándolos desde la izquierda de la misma.

    Una vez los tengas definidos, el siguiente código:
        string cadena = "En un lugar de La Mancha de cuyo nombre no quiero acordarme";
        Console.WriteLine(cadena.EstaVacia());
        Console.WriteLine(cadena.Invertir());
        Console.WriteLine(cadena.Left(11));
        Console.WriteLine(cadena.Right(9));

    Deberá devolver lo siguiente por pantalla:
        False
        emradroca oreiuq on erbmon oyuc ed ahcnaM aL ed ragul nu nE
        En un lugar
        acordarme
*/
    static void Main(string[] args)
    {
        string cadena = "En un lugar de La Mancha de cuyo nombre no quiero acordarme";
        Console.WriteLine(cadena.EstaVacia());
        Console.WriteLine(cadena.Invertir());
        Console.WriteLine(cadena.Left(11));
        Console.WriteLine(cadena.Right(9));
    }
}
