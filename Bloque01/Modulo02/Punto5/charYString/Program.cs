// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n===== CHAR =====");

char metodo1 = 'A';
char metodo2 = '\x0041'; // Utilizando el código hexadecimal
char metodo3 = (char)65; // Utilizando el código en decimal
char metodo4 = '\u0041'; // Utilizando el código Unicode

Console.WriteLine($"Char ''A'' = {metodo1}, hexadecimal '\\x0041' = {metodo2}, decimalCode (char)65 = {metodo3}, uniCode '\\u0041' = {metodo4}");

Console.WriteLine("\n===== STRING =====");

string cadena1 = "Texto";
string cadena2 = String.Empty;
Console.WriteLine($"cadena1 = '{cadena1}', cadena2 = '{cadena2}'");

Console.WriteLine("");
string Texto = "Hola Mundo!!!";
Console.WriteLine($"Texto = '{Texto}', Texto[5] = '{Texto[5]}'"); // Muestra por pantalla la letra M

Console.WriteLine("");
string CadenaTexto = "palabra1\tpalabra2\tpalabra3\r\npalabra4\tpalabra5\tpalabra6\r\npalabra7\tpalabra8\tpalabra9";
Console.WriteLine(CadenaTexto);

Console.WriteLine("");
string RutaArchivo1 = "C:\\Archivos de programa\\Ficheros\\prueba.txt";
string RutaArchiv02 = @"C:\Archivos de programa\Ficheros\prueba.txt";
Console.WriteLine($"METHODO DOBLE BARRA-INVERTIDA: {RutaArchivo1}");
Console.WriteLine($"METHODO ARROBA: {RutaArchiv02}");

Console.WriteLine("");
Console.WriteLine("\n===== UTF-8 string =====");
ReadOnlySpan<byte> AuthStringLiteral = "Nueva cadena en codificación UTF8"u8;
// Console.WriteLine("METHODO AuthStringLiteral: " + AuthStringLiteral);