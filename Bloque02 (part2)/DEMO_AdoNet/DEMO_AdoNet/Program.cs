using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        using (SqlConnection conexion = new SqlConnection("Persist Security Info=true;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019"))
        {
            conexion.Open();

            SqlCommand cmdSelect = new SqlCommand("SELECT COUNT(*) Total FROM Person.Person", conexion);
            SqlCommand cmdCount = new SqlCommand("SELECT TOP 3 BusinessEntityID, FirstName, LastName FROM Person.Person", conexion);
            SqlCommand cmdUpdate = new SqlCommand("UPDATE Person.Person Set FirstName = FirstName + '!' WHERE BusinessEntityID in (285, 293)", conexion);

            //TODO: Recorrer los registros

            Console.WriteLine($"++ Hay: {cmdSelect.ExecuteScalar()} registron en la tabla.\n");
            Console.WriteLine("\n===========  ===========  ===========  ===========  =========== \n");

            using (SqlDataReader reader = cmdCount.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    int index = 0;

                    while (reader.Read())
                    {
                        //Console.WriteLine($">> BusinessEntityID: {reader[0].ToString()}");
                        //Console.WriteLine($">> FirstName: {reader[1]}");
                        //Console.WriteLine($">> LastName: {reader[2]}");
                        //Console.WriteLine("----------- --- ----------- ");

                        Console.WriteLine($"Registro: {index++}");
                        Console.WriteLine($">> BusinessEntityID: {reader.GetInt32(0)}");
                        Console.WriteLine($">> FirstName: {reader.GetString(1)}");
                        Console.WriteLine($">> LastName: {reader.GetString(2)}");
                        Console.WriteLine("----------- --- ----------- --- ----------- --- ----------- ");

                    }
                }

                reader.Close();
            }

            var filasAfectadas = cmdUpdate.ExecuteNonQuery();
            Console.WriteLine($"Registros modificados: {filasAfectadas}");

            Console.WriteLine("\n===========  ===========  ===========  ===========  ===========\n");

            using (SqlDataReader reader = cmdCount.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    int index = 0;

                    while (reader.Read())
                    {
                        //Console.WriteLine($">> BusinessEntityID: {reader[0].ToString()}");
                        //Console.WriteLine($">> FirstName: {reader[1]}");
                        //Console.WriteLine($">> LastName: {reader[2]}");
                        //Console.WriteLine("----------- --- ----------- ");

                        Console.WriteLine($"Registro: {index++}");
                        Console.WriteLine($">> BusinessEntityID: {reader.GetInt32(0)}");
                        Console.WriteLine($">> FirstName: {reader.GetString(1)}");
                        Console.WriteLine($">> LastName: {reader.GetString(2)}");
                        Console.WriteLine("----------- --- ----------- --- ----------- --- ----------- ");

                    }
                }

                reader.Close();
            }

  

            conexion.Close();

        }

         Console.WriteLine("----------- END ----------- ");
    }
}