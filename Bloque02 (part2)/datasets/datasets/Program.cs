using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {

        using (var conexion = new SqlConnection("Persist Security Info=True;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019;Encrypt=false"))
        {
            DataSet ds = new DataSet();
            DataTable personas = new DataTable("Personas");
            ds.Tables.Add(personas);

            DataColumn idPersona = new DataColumn("ID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            personas.Columns.Add(idPersona);

            DataColumn nombre = personas.Columns.Add("Nombre", typeof(string));
            nombre.MaxLength = 50;
            nombre.AllowDBNull = false;

            DataColumn inicial = personas.Columns.Add("Inicial", typeof(string));
            nombre.MaxLength = 50;
            nombre.AllowDBNull = true;

            DataColumn apellidos = personas.Columns.Add("Apellidos", typeof(string));
            nombre.MaxLength = 50;
            nombre.AllowDBNull = false;

            personas.PrimaryKey = new[] { idPersona };

            SqlDataAdapter adaptador = new SqlDataAdapter("select BusinessEntityID,FirstName,MiddleName,LastName from Person.Person", conexion);


            DataTableMapping mapeo = new DataTableMapping("Table", "Personas");
            mapeo.ColumnMappings.Add("BusinessEntityID", "ID");
            mapeo.ColumnMappings.Add("FirstName", "Nombre");
            mapeo.ColumnMappings.Add("MiddleName", "Inicial");
            mapeo.ColumnMappings.Add("LastName", "Apellidos");
            adaptador.TableMappings.Add(mapeo);

            adaptador.Fill(ds);

            foreach (DataRow fila in ds.Tables["Personas"].Select("ID in (285,293,295)", "Nombre"))
            {
                Console.WriteLine($"{fila["ID"]} - {fila["Nombre"]} {fila["Apellidos"]}");
            }

            Console.WriteLine($"{ds.Tables["Personas"].Rows[55]["ID"]} - {ds.Tables["Personas"].Rows[55]["Nombre"]} {ds.Tables["Personas"].Rows[55]["Apellidos"]}");

            var nuevafila = ds.Tables["Personas"].NewRow();
            nuevafila["Nombre"] = "Pepe";
            nuevafila["Apellidos"] = "Fernández";
            ds.Tables["Personas"].Rows.Add(nuevafila);

            ds.Tables["Personas"].Rows[55]["Nombre"] = "nuevo nombre";

            ds.Tables["Personas"].AcceptChanges();
        }

        Console.ReadLine();
    }
}