namespace practica_M2P13;
class Program
{
    static void Main(string[] args)
    {
        /* 1.     
            Crea varias variables de tipo string que se llamen de la misma forma pero variando mayúsculas y minúsculas.
            Por ejemplo hola, Hola y HOLA. A cada una asígnale un valor diferente y luego muéstralas por pantalla usando 
            Console.WriteLine. 
            ¿Qué se muestra? 
            ¿Se produce algún error? 
            ¿Es posible tener en C# varias variables con el mismo nombre distinguiéndolas solamente por mayúsculas o minúsculas? 
            ¿Te parece razonable hacerlo así en caso de que la respuesta sea afirmativa y sea posible?
        */
        string stringVar = "Hola 1";
        string StringVar = "Hola 2";
        string stringvar = "Hola 3";
        string Stringvar = "Hola 4";
        Console.WriteLine($"1. stringVar={stringVar},StringVar={StringVar},stringvar={stringvar},Stringvar={Stringvar}\n");

        /* 2.
            Crea dos variables de diferente tipo (por ejemplo una cadena y un entero) y por lo tanto con valores diferentes, 
            pero con el mismo nombre exactamente incluyendo mayúsculas y minúsculas. 
            ¿Se produce algún error o, como son de tipo diferente te lo permite?, 
            ¿te parece razonable, le ves alguna utilidad a hacerlo así?
        */
        string intString = "Soy String";
        // int intString = 1001;
        Console.WriteLine("2. Una variable o función local denominada 'intString' ya se ha definido en este ámbito [practica_M2P13]csharp(CS0128)\n");

        /* 3.
            Ahora crea una variable y una constante con exactamente el mismo nombre (incluyendo mayúsculas y minúsculas) pero valores diferentes. 
            Muéstralas por pantalla. 
            ¿Se produce un error o al ser cosas diferentes te funciona? En caso de estar permitido ¿te parece razonable, le ves alguna utilidad a hacerlo así?
        */
        // string PI = "3.14M";
        const decimal PI = 3.14M;
        Console.WriteLine("3. Una variable o función local denominada 'PI' ya se ha definido en este ámbito [practica_M2P13]csharp(CS0128)\n");

        /* 4.
            ¿Cuántas maneras conoces de declarar una variable del mismo tipo, por ejemplo un entero? 
            Al menos deberías saber hacerlo con el nombre específico de C# y con el nombre de CTS.
        */
        int int1 = 123;
        Int32 int2 = 234;
        var int3 = 345;
        Console.WriteLine($"4. int1={int1}, int2={int2}, int3={int3}\n");

        /* 5.
            Crea una variable de tipo decimal y asígnale un valor literal, por ejemplo así: decimal d = 1.23;. 
            Muéstrala por pantalla. Verás que al ejecutar la aplicación se produce un error y no te lo permite. 
            ¿A qué es debido? 
            ¿Cómo podrías asignar ese literal 1.23 a una variable de tipo decimal sin necesidad de hacer una conversión explícita?

            Una pista: existe una forma de indicar el tipo que queremos para un literal mediante el uso de sufijos especiales. 
            Es lo que se denomina notación literal.

            Por ejemplo, en este caso se solucionaría usando el sufijo "m" que indica que un literal es de tipo decimal, así: decimal d = 1.23m;. 
            Se pueden utilizar en minúsculas o mayúsculas.
            Averigua qué sufijos existen y acuérdate de ellos por si alguna vez te hacen falta.
        */
        // decimal dec = 1.23;
        Console.WriteLine("5. El literal de tipo double no se puede convertir implícitamente en el tipo 'decimal'; use un sufijo 'M' para crear un literal de este tipo [practica_M2P13]csharp(CS0664)");
        decimal dec = 1.23M;
        Console.WriteLine($">> dec=1.23M, dec={dec}\n");

        /* 6.
            Crea un pequeño programa que muestre por pantalla un conjunto de letras "X" separadas entre sí a la misma distancia, formando 5 filas y 3 columnas. 
            Para ello tendrás que crear una cadena de texto apropiadamente formateada con caracteres especiales. 
            ¿Qué pasa si usas únicamente la secuencia de escape \r o \n para los cambios de línea?
        */
        Console.WriteLine("6. \n-----------------------------------------------------------------\n");
        Console.WriteLine("=> \\n");
        Console.WriteLine("X X X\nX X X\nX X X\nX X X\nX X X\n");
        Console.WriteLine("=> \\r\\n");
        Console.WriteLine("X X X\r\nX X X\r\nX X X\r\nX X X\r\nX X X\n");
        Console.WriteLine("=> \\r");
        Console.WriteLine("X X X\rX X X\rX X X\rX X X\rX X X\n\n");

        /* 7.
            ¿Cuál sería el mejor método para asignar a una variable una cadena que conste de varias líneas 
            y sin utilizar secuencias de escape? 
            Asigna algo así a una variable y prueba.
        */
        string cadenaMultiLineas = @"¿Cuál sería el mejor método para asignar 
a una variable una cadena que conste 
de varias líneas 
y sin utilizar secuencias de escape?";
        Console.WriteLine("7. " + cadenaMultiLineas + "\n\n");

        /* 8.
            Crea una variable de tipo long y asígnale el valor numérico 1234567890123456789. 
            Ahora crea otra variable de tipo int y asígnale la variable anterior. 
            ¿Te lo permite? 
            ¿Por qué? Ahora haz una conversión explícita de la primera variable en un int 
            (repasa las conversiones explícitas de tipos) y muestra el valor contenido en la nueva variable. 
            ¿Te ha permitido la conversión? 
            ¿Qué número te muestra por pantalla? 
            ¿A qué es debido? Ahora ponle un 0 más al final al primer literal 
            ¿Qué ocurre? ¿Cómo lo solucionarías?
        */
        long numeroLong = 1234567890123456789;
        // Añadiendo un 0 al final del long = "No se puede convertir implícitamente el tipo 'ulong' en 'long'." 
        int numeroInt = (int)numeroLong;
        Console.WriteLine($"8. numeroLong={numeroLong}, numeroInt={numeroInt}\n\n");

        /* 9.
            Si declaras una variable de tipo numérico cualquiera, por ejemplo un entero largo (long) 
            pero no le asignas valor alguno 
            ¿qué contendrá? 
            ¿Estará definida? 
            ¿Dará un error al intentar mostrarla por pantalla? 
            ¿Cómo podrías asignar el valor por defecto de una variable sin especificarlo tú manualmente (o sea, sin sabértelo)? 
            (Aquí una pista. Esto será útil más adelante en el curso).
        */
        long? varVacia = null;
        long varCopia = varVacia ?? 0;

        Console.WriteLine($"9. varCopia={varCopia}\n\n");

        /* 10.
            ¿Qué crees que te devolverá este código por pantalla?:

            int i = 5;
            double d = i/2;
            Console.WriteLine(d);
            ¿Por qué no devuelve "2.5" que es el resultado de la operación si d es una variable de tipo double? 
            ¿Cómo lo solucionarías? (Pista: recuerda la notación literal).
        */

        Console.WriteLine("10. Devuelve 2, por que solo se guarda la parte de enteros");
        int i = 5;
        double d = i / 2;
        Console.WriteLine($"i={i}, d=i/2 => {d}");
        double d2 = i / (double)2;
        Console.WriteLine($"i={i}, d2=i/(double)2 => {d2}\n\n");
        /* 11.
            Declara una variable de tipo entero con un valor inicial de 5 y otra variable de tipo double sin valor inicial asociado. 
            Ahora asigna mediante operaciones matemáticas un valor en la segunda variable que sea el resultado de multiplicar el valor 
            de la primera por 7, sumarle el resultado de 2 + 4 y dividirlo todo entre 2, todo ello en una sola línea de código. 
            Muéstralo por pantalla. 
            
            Si has colocado bien los paréntesis, has utilizado las normas de precedencia de operadores apropiadamente 
            y los tipos de datos apropiados en los literales deberías obtener un 20.5. 
            
            Si no obtienes eso es que estás haciendo algo mal. 
            Repásalo hasta conseguirlo y entender bien por qué.
        */

        int inicial = 5;
        double resultado;

        resultado = ((inicial * 7) + 2 + 4) / 2D;


        Console.WriteLine($"11. Resultado: `{resultado}` , espected `20.5`\n\n");
    }
}
