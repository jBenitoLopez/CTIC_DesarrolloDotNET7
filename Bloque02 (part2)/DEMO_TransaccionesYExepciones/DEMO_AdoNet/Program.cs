using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        using (SqlConnection conexion = new SqlConnection("Persist Security Info=true;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019"))
        {
            conexion.Open();



            using (var trans = conexion.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdSelect = new SqlCommand("SELECT TOP 15 BusinessEntityID, FirstName, LastName FROM Person.Person ORDER BY BusinessEntityID", conexion);
                    cmdSelect.Transaction = trans;

                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int index = 0;

                            while (reader.Read())
                            {
                                Console.Write($"Registro: {index++}");
                                Console.Write($"; BusinessEntityID: {reader.GetInt32(0)}");
                                Console.Write($"; FirstName: {reader.GetString(1)}");
                                Console.Write($"; LastName: {reader.GetString(2)}\n");
                            }
                        }

                        reader.Close();
                    }

                    SqlCommand cmdUpdate1 = new SqlCommand("UPDATE Person.Person Set FirstName = FirstName + '1' WHERE BusinessEntityID = 1", conexion);
                    cmdUpdate1.Transaction = trans;
                    var filasAfectadas1 = cmdUpdate1.ExecuteNonQuery();
                    trans.Save("punto1");

                    var filasAfectadas2 = 0;
                    var filasAfectadas3 = 0;
                    try
                    {
                        SqlCommand cmdUpdate2 = new SqlCommand("UPDATE Person.Person Set FirstName = FirstName + '2' WHERE BusinessEntityID = 2", conexion);
                        cmdUpdate2.Transaction = trans;
                        filasAfectadas2 = cmdUpdate2.ExecuteNonQuery();

                        SqlCommand cmdUpdate3 = new SqlCommand("UPDATE Person.Person Set FirstName33 = FirstName + '3' WHERE BusinessEntityID = 3", conexion);
                        cmdUpdate3.Transaction = trans;
                        filasAfectadas3 = cmdUpdate3.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        filasAfectadas2 = 0;
                        filasAfectadas3 = 0;
                        trans.Rollback("punto1");
                    }
     


                    SqlCommand cmdUpdate4 = new SqlCommand("UPDATE Person.Person Set FirstName = FirstName + '4' WHERE BusinessEntityID = 4", conexion);
                    cmdUpdate4.Transaction = trans;
                    var filasAfectadas4 = cmdUpdate4.ExecuteNonQuery();

                    Console.WriteLine($"Filas Afectadas (1): {filasAfectadas1}; (2): {filasAfectadas2}; (3): {filasAfectadas3}; (4): {filasAfectadas4}");
                    Console.WriteLine("=========================================================================================");

                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int index = 0;

                            while (reader.Read())
                            {
                                Console.Write($"Registro: {index++}");
                                Console.Write($"; BusinessEntityID: {reader.GetInt32(0)}");
                                Console.Write($"; FirstName: {reader.GetString(1)}");
                                Console.Write($"; LastName: {reader.GetString(2)}\n");
                            }
                        }

                    }

                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"\nERROR OutOfRangeException: {ex.Message}");
                    trans.Rollback();
                    throw;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"\nERROR SqlException: {ex.Message}");
                    trans.Rollback();
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nERROR Exception: {ex.Message}");
                    trans.Rollback();
                    throw;
                }

                trans.Commit();
            }

            conexion.Close();
        }

         Console.WriteLine("----------- END ----------- ");
    }
}