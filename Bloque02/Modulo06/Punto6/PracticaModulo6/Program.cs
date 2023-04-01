namespace PracticaModulo6;
class Program
{
    static void Main(string[] args)
    {

        Persona p1 = new Persona("Nombre", "Apellido");
        Persona p2 = p1;
        Persona p3 = new Persona("Nombre", "Apellido");
        Persona p4 = new Persona("Nombre4", "Apellido4");

        Alumno a1 = new("Alumno", "Apellido");
        Alumno a2 = a1;
        Alumno a3 = new("Alumno", "Apellido");
        Alumno a4 = new("Alumno4", "Apellido4");

        Conserje c1 = new("Conserje", "Apellido");
        Conserje c2 = c1;
        Conserje c3 = new("Conserje", "Apellido");
        Conserje c4 = new("Conserje4", "Apellido4");

        Profesor pf1 = new("Profesor", "Apellido");
        Profesor pf2 = pf1;
        Profesor pf3 = new("Profesor", "Apellido");
        Profesor pf4 = new("Profesor4", "Apellido4");
        // ---
        #region "1. Tarea"
        /* 1. Crea un método Igualdad que recibe dos parámetros.
              - Los parámetros podrán ser de cualquier tipo, y será en el momento de llamar al 
                método cuando definamos el tipo.
              - Deberá devolver un valor booleano que nos informe si ambos parámetros son 
                iguales o no 

              Cuando pruebes el método, no solo pruebes a pasarle dos números enteros, prueba 
              con otros tipos de datos incluido algún objeto que crees (puedes utilizar las 
              clases de ejemplo del curso para crearlo) y mira a ver si creando dos objetos 
              del mismo tipo te da como igual o no...
        */
        Console.WriteLine("=== TAREA 1 ===");
        Console.WriteLine($"(int) Los parametros {(Igualdad(1, 1) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(int) Los parametros {(Igualdad(1, 2) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(string) Los parametros {(Igualdad("1", "1") ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(string) Los parametros {(Igualdad("1", "2") ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(persona1) Los parametros {(Igualdad(p1, p2) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(persona3) Los parametros {(Igualdad(p1, p3) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(persona4) Los parametros {(Igualdad(p1, p4) ? "Son iguales" : "No son iguales")}.");
        #endregion "1. Tarea"
        // ---
        #region "2. Tarea"
        /* 2. En temas anteriores ya hemos visto el uso de las clases, interfaces, herencia, 
              poliformismo, etc... para lo cual nos hemos ayudado en la teoría de unas clases 
              Persona, Alumno, Profesor o Conserje.
        
              Modifica el método anterior de forma que te permita realizar la comparación de 
              objetos de tipo Profesor y Conserje pero no de tipo Alumno para lo cual te puedes 
              ayudar de lo aprendido en la programación orientada a objetos.
        
              ¿Qué ocurre si ahora intentas utilizarlo con números o cadenas?
        */
        Console.WriteLine("=== TAREA 2 ===");
        // Console.WriteLine($"(int1) Los parametros {(Igualdad2(1, 1) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(int2) Los parametros {(Igualdad2(1, 2) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(string1) Los parametros {(Igualdad2("1", "1") ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(string2 Los parametros {(Igualdad2("1", "2") ? "Son iguales" : "No son iguales")}.");

        // Console.WriteLine($"(persona1) Los parametros {(Igualdad2(p1, p2) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(persona3) Los parametros {(Igualdad2(p1, p3) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(persona4) Los parametros {(Igualdad2(p1, p4) ? "Son iguales" : "No son iguales")}.");

        // Console.WriteLine($"(Alumno1) Los parametros {(Igualdad2(a1, a2) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(Alumno3) Los parametros {(Igualdad2(a1, a3) ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(Alumno4) Los parametros {(Igualdad2(a1, a4) ? "Son iguales" : "No son iguales")}.");

        Console.WriteLine($"(conserje1) Los parametros {(Igualdad2(c1, c2) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(conserje3) Los parametros {(Igualdad2(c1, c3) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(conserje4) Los parametros {(Igualdad2(c1, c4) ? "Son iguales" : "No son iguales")}.");

        Console.WriteLine($"(profesor1) Los parametros {(Igualdad2(pf1, pf2) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(profesor3) Los parametros {(Igualdad2(pf1, pf3) ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(profesor4) Los parametros {(Igualdad2(pf1, pf4) ? "Son iguales" : "No son iguales")}.");

        #endregion "2. Tarea"
        // ---
        #region "3. Tarea"
        /* 3. Integra el método anterior dentro de una clase, en la cual declararás los tipos de 
              los datos que vas a utilizar.

              Elimina los parámetros de la función, y en su lugar pasa los datos mediante dos 
              propiedades, de forma que al llamar a la función obtendrá los datos de las propiedades 
              para hacer la comparación. De esta forma para llamar al método será necesario 
              instanciar la clase y pasar previamente los datos al objeto antes de hacer la llamada.
        
              ¿Qué ocurrirá si llamamos a la función antes de pasar los parámetros? 
              ¿Qué modificación tendremos que hacer para que el método se pueda ejecutar sin 
              problemas empleando datos por defecto?
        */
        Console.WriteLine("=== TAREA 3 ===");

        // Comparar<int> cint1 = new();
        // cint1.Param1 = 1;
        // cint1.Param2 = 1;
        // Comparar<int> cstr2 = new();
        // cint2.Param1 = 1;
        // cint2.Param2 = 2;
        // Console.WriteLine($"(int1) Los parametros {(cint1.Igualdad() ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(int2) Los parametros {(cint2.Igualdad() ? "Son iguales" : "No son iguales")}.");
        // ---
        // Comparar<string> cstr1 = new();
        // cstr1.Param1 = "1";
        // cstr1.Param2 = "1";
        // Comparar<string> cstr2 = new();
        // cstr2.Param1 = "1";
        // cstr2.Param2 = "2";
        // Console.WriteLine($"(string1) Los parametros {(cstr1.Igualdad() ? "Son iguales" : "No son iguales")}.");
        // Console.WriteLine($"(string2) Los parametros {(cstr2.Igualdad() ? "Son iguales" : "No son iguales")}.");
        // ---
        // Comparar<Persona> cstr1 = new();
        // Comparar<Persona> cstr2 = new();
        // ---
        // Comparar<Alumno> cstr1 = new();
        // Comparar<Alumno> cstr2 = new();
        // ---
        Comparar<Conserje> ccon1 = new();
        ccon1.Param1 = c1;
        ccon1.Param2 = c2;
        Comparar<Conserje> ccon3 = new();
        ccon3.Param1 = c1;
        ccon3.Param2 = c3;
        Comparar<Conserje> ccon4 = new();
        ccon4.Param1 = c1;
        ccon4.Param2 = c4;
        Console.WriteLine($"(conserje1) Los parametros {(ccon1.Igualdad() ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(conserje3) Los parametros {(ccon3.Igualdad() ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(conserje4) Los parametros {(ccon4.Igualdad() ? "Son iguales" : "No son iguales")}.");
        // ---
        Comparar<Profesor> cpro1 = new();
        cpro1.Param1 = pf1;
        cpro1.Param2 = pf2;
        Comparar<Profesor> cpro3 = new();
        cpro3.Param1 = pf1;
        cpro3.Param2 = pf3;
        Comparar<Profesor> cpro4 = new();
        cpro4.Param1 = pf1;
        cpro4.Param2 = pf4;
        Console.WriteLine($"(Profesor1) Los parametros {(cpro1.Igualdad() ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(Profesor3) Los parametros {(cpro3.Igualdad() ? "Son iguales" : "No son iguales")}.");
        Console.WriteLine($"(Profesor4) Los parametros {(cpro4.Igualdad() ? "Son iguales" : "No son iguales")}.");
        #endregion "3. Tarea"
        // ---
        #region "4. Tarea"
        /* 4. Ahora añade un segundo método a la clase que permita devolver la unión de los dos 
              parámetros dependiendo de su tipo

              - En el caso de tratarse de una de las clases admitidas se tratará del texto Nombre 
                Apellido de la primera propiedad concatenado con el Nombre Apellido de la segunda.

              - En el caso que los datos sean cadenas de caracteres, las devolverá concatenadas.

              - Si se trata de números o fechas, devolverá una cadena de texto con la suma de ambas 
                propiedades.

                Esto te permitirá trabajar con el tipo de los datos, de forma que manejes de distinta 
                manera uno u otro. Para esto recuerda los operadores is y as.
        */
        Console.WriteLine("=== TAREA 4 ===");
        Comparar4<Conserje> comparar4a = new();
        comparar4a.Param1 = c1;
        comparar4a.Param2 = c2;
        Console.WriteLine("(Conserje) " + comparar4a.Mostrar());

        Comparar4<Profesor> comparar4p = new();
        comparar4p.Param1 = pf1;
        comparar4p.Param2 = pf2;
        Console.WriteLine("(Profesor) " + comparar4p.Mostrar());

        Comparar4<int> comparar4b = new();
        comparar4b.Param1 = 1;
        comparar4b.Param2 = 1;
        Console.WriteLine("(int) " + comparar4b.Mostrar());

        Comparar4<string> comparar4c = new();
        comparar4c.Param1 = "1";
        comparar4c.Param2 = "1";
        Console.WriteLine("(string) " + comparar4c.Mostrar());


        #endregion "4. Tarea"
        // ---
    }
    // === Methods ===
    #region "1.Tarea"
    private static bool Igualdad<T>(T param1, T param2)
    {
        if (param1 == null || param2 == null)
        {
            return false;
        }
        else if (param1.Equals(param2))
        {
            return true;
        }

        return false;
    }
    #endregion "1.Tarea"

    #region "2.Tarea"
    private static bool Igualdad2<T>(T param1, T param2)
      where T : IComparar
    {
        return param1.Equals(param2);
    }

    #endregion "1.Tarea"


}



/* 5. Modifica lo hecho hasta ahora para que puedas pasar los datos en el momento de 
     instanciar la clase mediante un constructor. ¿Se pueden seguir empleando los genéricos 
     con los constructores?
*/

/* 6. Ya has empleado anteriormente las matrices, por lo que ahora vamos a trabajar con ellas.
     Crea un método que imprimirá por consola un valor, para lo cual recibirá dos parámetros:

    - El primero será un array de enteros o cadenas de caracteres. Para obtener los datos, 
      solicítaselos al usuario a través de la consola.

    - El segundo será de tipo numérico e indicará la posición a imprimir del array. 
      Determina su valor de forma aleatoria mediante la clase Random.

      Finalmente el método imprimirá por consola el valor de la matriz situado en la posición 
      especificada por el parámetro numérico.

      ¿Cómo podrás hacer para que acepte distintos tipos de matrices? 
      ¿El primer parámetro será necesario que sea también un genérico? 
      Ten en cuenta que si permites más tipos de datos que no sean matrices, deberás informar 
      que el tipo no es válido.
*/

/* 7. Crea una interfaz que obligue a que toda clase que la implemente, tenga que tener una 
     serie de propiedades y métodos:

    - Propiedad Nombre de tipo string.

    - Las propiedades Peso y Altura cuyo tipo lo determinará la clase que implemente la 
      interfaz, puesto que pueden querer decimales (tipo decimal, double, etc...) 
      o no (tipo int, long, etc...).

    - Método MostrarDatosFisicos que deberá mostrar por consola el texto "X pesa Y kilos 
      y mide Z metros", donde X es Nombre, Y Peso y Z Altura.

     A continuación modifica la clase Persona de la teoría o crea una nueva, para que 
     implemente la interfaz que acabas de hacer. Después crea un par de objetos de tipo 
     Persona con todos los datos, para llamar posteriormente al método MostrarDatosFisicos.   
  */