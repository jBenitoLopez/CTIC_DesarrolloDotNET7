﻿namespace PracticaModulo6;
class Program
{

    /*
    Crea un método Igualdad que recibe dos parámetros.
        * Los parámetros podrán ser de cualquier tipo, y será en el momento de llamar al método cuando definamos el tipo.
        * Deberá devolver un valor booleano que nos informe si ambos parámetros son iguales o no.
          Cuando pruebes el método, no solo pruebes a pasarle dos números enteros, prueba con otros tipos de datos incluido algún objeto que crees (puedes utilizar las clases de ejemplo del curso para crearlo) y mira a ver si creando dos objetos del mismo tipo te da como igual o no...

    En temas anteriores ya hemos visto el uso de las clases, interfaces, herencia, poliformismo, etc... para lo cual nos hemos ayudado en la teoría de unas clases Persona, Alumno, Profesor o Conserje.

    Modifica el método anterior de forma que te permita realizar la comparación de objetos de tipo Profesor y Conserje pero no de tipo Alumno para lo cual te puedes ayudar de lo aprendido en la programación orientada a objetos.

    ¿Qué ocurre si ahora intentas utilizarlo con números o cadenas?

    Integra el método anterior dentro de una clase, en la cual declararás los tipos de los datos que vas a utilizar.

    Elimina los parámetros de la función, y en su lugar pasa los datos mediante dos propiedades, de forma que al llamar a la función obtendrá los datos de las propiedades para hacer la comparación. De esta forma para llamar al método será necesario instanciar la clase y pasar previamente los datos al objeto antes de hacer la llamada.

    ¿Qué ocurrirá si llamamos a la función antes de pasar los parámetros? ¿Qué modificación tendremos que hacer para que el método se pueda ejecutar sin problemas empleando datos por defecto?

    Ahora añade un segundo método a la clase que permita devolver la unión de los dos parámetros dependiendo de su tipo

    En el caso de tratarse de una de las clases admitidas se tratará del texto Nombre Apellido de la primera propiedad concatenado con el Nombre Apellido de la segunda.

    En el caso que los datos sean cadenas de caracteres, las devolverá concatenadas.

    Si se trata de números o fechas, devolverá una cadena de texto con la suma de ambas propiedades.

    Esto te permitirá trabajar con el tipo de los datos, de forma que manejes de distinta manera uno u otro. Para esto recuerda los operadores is y as.

    Modifica lo hecho hasta ahora para que puedas pasar los datos en el momento de instanciar la clase mediante un constructor. ¿Se pueden seguir empleando los genéricos con los constructores?

    Ya has empleado anteriormente las matrices, por lo que ahora vamos a trabajar con ellas.

    Crea un método que imprimirá por consola un valor, para lo cual recibirá dos parámetros:

    El primero será un array de enteros o cadenas de caracteres. Para obtener los datos, solicítaselos al usuario a través de la consola.

    El segundo será de tipo numérico e indicará la posición a imprimir del array. Determina su valor de forma aleatoria mediante la clase Random.

    Finalmente el método imprimirá por consola el valor de la matriz situado en la posición especificada por el parámetro numérico.

    ¿Cómo podrás hacer para que acepte distintos tipos de matrices? ¿El primer parámetro será necesario que sea también un genérico? Ten en cuenta que si permites más tipos de datos que no sean matrices, deberás informar que el tipo no es válido.

    Crea una interfaz que obligue a que toda clase que la implemente, tenga que tener una serie de propiedades y métodos:

    Propiedad Nombre de tipo string.

    Las propiedades Peso y Altura cuyo tipo lo determinará la clase que implemente la interfaz, puesto que pueden querer decimales (tipo decimal, double, etc...) o no (tipo int, long, etc...).

    Método MostrarDatosFisicos que deberá mostrar por consola el texto "X pesa Y kilos y mide Z metros", donde X es Nombre, Y Peso y Z Altura.

    A continuación modifica la clase Persona de la teoría o crea una nueva, para que implemente la interfaz que acabas de hacer. Después crea un par de objetos de tipo Persona con todos los datos, para llamar posteriormente al método MostrarDatosFisicos.   
        
    */
    static void Main(string[] args)
    {

    }
}
