namespace TareaModulo3;
class Program
{
    static void Main(string[] args)
    {


        /* 1.
            Define tres variables, n1, n2 y n3. 
            Crea un condicional que muestre por pantalla siempre el mayor de los tres números. 
            OJO, es más complicado de lo que parece. 
            Debes tener en cuenta que dos o más de esos números sean iguales y que el orden en el 
            que estén definidos sea cualquiera. 
            Para comprobar que la lógica que has creado funciona prueba a variar el valor de los 
            3 números y colócalos en orden ascendente, descendente, con dos o los tres valores iguales, etc... 
            y comprueba que siempre devuelve la misma información.
        */
        Console.WriteLine("\n----- ----- 1. ----- -----");

        int n1 = 22;
        int n2 = 33;
        int n3 = 11;

        Console.WriteLine($"Cual es el numer mas alto de los 3? n1={n1}, n2={n2}, n3={n3}");
        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine("El numero mas alto es `n1`");
        }
        else if (n2 > n3 && n2 > n1)
        {
            Console.WriteLine("El numero mas alto es `n2`");
        }
        else if (n3 > n1 && n3 > n2)
        {
            Console.WriteLine("El numero mas alto es `n3`");
        }
        else
        {
            Console.WriteLine("Tenemos un empate :/");
        }

        /* 2.
            Ahora vamos a llevar un paso más allá el ejercicio anterior. 
            Define una matriz de números enteros que contenga como mínimo 5. 
            Procura que no estén ordenados ascendentemente e incluso que haya algunos iguales. 
            Ahora, utiliza un bucle para recorrer la matriz y extraer el número mayor de todos los de la matriz. 
            Haz lo mismo para extraer el número menor. 
            Pruébalo bien usando diferentes matrices de valores para asegurarte de que lo hace bien.
        */
        Console.WriteLine("\n----- ----- 2. ----- -----");

        int[] arrayDeNumeros = new int[5] { 44, 22, 66, 11, 22 };
        int numMin = arrayDeNumeros[0];
        int numMax = arrayDeNumeros[0];
        for (int i = 1; i < arrayDeNumeros.Length; i++)
        {
            if (numMin > arrayDeNumeros[i])
            {
                numMin = arrayDeNumeros[i];
            }

            if (numMax < arrayDeNumeros[i])
            {
                numMax = arrayDeNumeros[i];
            }
        }
        Console.WriteLine($"Numeros del array: {String.Join(", ", arrayDeNumeros)}");
        Console.WriteLine($"El numero mas baja es {numMin} y el mas alto {numMax}.");
        /* 3.
            Crea un programa en C# que le pida al usuario que introduzca un número entero (Pista: usa el método Console.ReadLine) 
            y que muestre por pantalla el mismo valor multiplicado por 3 (o sea, si introduce un 5 que muestre un 15). 
            Que repita esta operación hasta que el usuario introduzca un 0.
        */
        Console.WriteLine("\n----- ----- 3. ----- -----");

        // int numero = 0;

        // do
        // {
        //     Console.WriteLine("Dame un numero (0 para salir): ");
        //     numero = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine($"El resultado es {numero * 3}");
        // } while (numero != 0);

        /* 4.
            Una vez que tengas funcionando el programa anterior, ¿qué pasa si el usuario introduce algo que no es un número?: 
            asegúrate de que el programa funciona incluso cuando esto ocurre, en cuyo caso deberás mostrar un mensaje de error 
            diciendo "valor no válido: debes introducir un número entero" 
            
            Pista: utiliza la conversión de tipos y concretamente el método TryParse de los enteros.
        */

        Console.WriteLine("\n----- ----- 4. ----- -----");

        // int numero = 0;
        // bool success = false;

        // do
        // {
        //     Console.Write("\nDame un numero (0 para salir): ");
        //     success = Int32.TryParse(Console.ReadLine(), out numero);
        //     if(success){
        //         if(numero == 0) break;

        //         Console.WriteLine($" - El resultado es {numero * 3}");
        //     } else {
        //         Console.WriteLine($" - valor no válido: debes introducir un número entero");
        //     }
        // } while (true);

        /* 5.
            Crea un programa que le pida un número entero del 1 al 9 al usuario (comprueba que no introduzca algo fuera de ese rango) 
            y que muestre por pantalla la tabla de multiplicar de ese número, escribiéndola de manera similar a esta:

            9 x 1 = 9 
            9 x 2 = 18 
            9 x 3 = 27 
            .....
        */
        Console.WriteLine("\n----- ----- 5. ----- -----");

        // int numero2 = 0;
        // do
        // {
        //     Console.Write("Introduce un numero entre el 1 y 9: ");
        //     bool esNumerico = Int32.TryParse(Console.ReadLine(), out numero2);

        //     if (esNumerico && numero2 > 0 && numero2 < 10)
        //     {
        //         break;
        //     }
        // } while (true);


        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($" {numero2} x {i} = {numero2 * i}");
        // }
        // Console.WriteLine("");

        /* 6.
            Ahora crea un programa similar al anterior pero que en este caso muestre las 
            tablas de multiplicar como las anteriores del 2 al 5. (Pista: para ello deberás usar dos bucles anidados).
        */
        Console.WriteLine("\n----- ----- 6. ----- -----");
        Console.WriteLine("");
        for (int x1 = 2; x1 <= 5; x1++)
        {
            for (int x2 = 1; x2 <= 10; x2++)
            {
                Console.WriteLine($" {x1} x {x2} = {x1 * x2}");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");

        /* 7.
            Crea un pequeño programa de consola que le solicite al usuario una clave de texto. 
            Mientras la clave introducida no sea la cadena "secreto", muéstrale un mensaje de 
            "Acceso denegado" y síguele pidiendo que la introduzca hasta que la introduzca bien 
            o hasta que lo haya intentado al menos 5 veces, en cuyo caso terminaría el programa. 
            Si la introduce bien muéstrale el mensaje "Acceso concedido" y termina también el programa.
        */
        Console.WriteLine("\n----- ----- 6. ----- -----");
        // int contador = 0;
        // do
        // {
        //     contador++;
        //     Console.Write("Cual es tu clave: ");
        //     string clave = Console.ReadLine() ?? "";

        //     if (clave == "secreto")
        //     {
        //         Console.WriteLine("Acceso concedido");
        //         break;
        //     }
        //     else if (contador > 5)
        //     {
        //         Console.WriteLine("Acceso denegado");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Acceso denegado");
        //     }
        // } while (true);

        /* 8.
            Crea un programa que le pida un número al usuario y que muestre por pantalla todos los números 
            que hay entre el 1 y el número introducido, ambos incluidos. 
            Crea tres versiones del programa, una usando un bucle for, otra usando un bucle while y otra usando un bucle do-while. 
            OJO: en todos los casos debe incluir tanto el 1 como el número introducido, es decir, deben formar parte del bucle.
        */
        Console.WriteLine("\n----- ----- 8. ----- -----");


        /* 9.
            Crea un programa que le solicite un número al usuario y que muestre todos los números impares que haya desde 
            el 1 al número introducido, excepto el 15 y el 21 (en caso de que se llegue tan arriba). 
            Para ello utiliza un bucle determinado y la palabra clave continue.
        */
        Console.WriteLine("\n----- ----- 9. ----- -----");

        /* 10.
            Crea un programa al que se le pase un número entero y te diga por cuántas cifras está formado. 
            Por ejemplo, si se introduce 316 debería devolver un 3. 
            (Pista: puedes averiguarlo dividiendo entre 10 varias veces hasta que... eso averígualo tú...). 
            Otra cosa: Si el número introducido es negativo conviértelo en positivo antes de realizar la operación.
        */
        Console.WriteLine("\n----- ----- 10. ----- -----");
        // int num3 = 0;

        // System.Console.Write("Dame un numero entero: ");
        // bool isANumber = Int32.TryParse(Console.ReadLine(), out num3);

        // if(isANumber){
        //     if(num3 < 0){
        //         num3 = num3 * -1;
        //     }
        //     string num3str = num3.ToString();
        //     System.Console.WriteLine($"El numero tiene {num3str.Length} cifras;");
        // }
        /* 11.
            Crea un programa que le pida al usuario varios números (hasta que no meta ninguno más) 
            y luego muestre por pantalla unas estadísticas básicas sobre los números introducidos: 
            cuántos son, la media, el máximo y el mínimo. 
            
            Crea dos versiones del mismo programa: 
            una que solo use estructuras y vaya calculando sobre la marcha los valores 
            y otra que los almacene en una matriz a medida que se van introduciendo 
            y que haga los cálculos después.
        */
        Console.WriteLine("\n----- ----- 11. ----- -----");

        /* 12.
            Crea un programa que pida un número entre 0 y 10 y que muestre con qué nota se 
            corresponde en la siguiente tabla de valoración de exámenes (No uses el if-else):
        
            De 0 a 5: Suspenso 
            De 5 a 7: Aprobado 
            De 7 a 9: Notable 
            De 9 a 10: Sobresaliente
        */
        Console.WriteLine("\n----- ----- 12. ----- -----");



        /* 13.
            ¿Cómo escribirías una expresión en una sola línea y sin usar if-else que, 
            dados dos números, te dijese cuál de los dos es el menor? 
            (Pista: debes utilizar el operador ternario).
        */
        Console.WriteLine("\n----- ----- 13. ----- -----");


        /* 14.
            Solicita al usuario un número entero y devuelve por pantalla si se trata de un número primo o no 
            (un número primo solo es divisible entre sí mismo y entre 1). (Pista: deberás usar un bucle, condicionales y el operador %).
        */
        Console.WriteLine("\n----- ----- 14. ----- -----");

        /* 15.
            Para "nota": crea un programa que pida al usuario el precio de un producto y el dinero con el que va a pagar 
            (que siempre debe ser mayor que el precio) y que calcule la vuelta que tendrías que darle usando billetes 
            de 50, 20, 10, 5 y monedas de 2 y 1€. 
            
            Es decir, que haga algo así por pantalla:
            ¿Precio?: 37
            ¿Me pagas con ....?: 100
            Tu cambio es 63: 50 10 2 1
        */
        Console.WriteLine("\n----- ----- 15. ----- -----");


    }
}
