using DEMO_EntityF.Contexto;
using System;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Orm();
    }

    public static void Orm()
    {

       using (var contexto = new AppDatosContext())
        {
            foreach (var cliente in contexto.Producto.Take(20).ToList())
            {
                Console.WriteLine($"Producto: {cliente.Nombre}");
            }
        }

        using (var contexto = new AppDatosContext())
        {
            foreach (var cliente in contexto.Producto.Where(prd => prd.Nombre.StartsWith("A")).Take(20))
            {
                Console.WriteLine($"Producto: {cliente.Nombre}");
            }
        }
    }
}