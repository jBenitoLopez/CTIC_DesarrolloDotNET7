using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //Manual();
        //Automatico();
        SemiAutomatico();

        Console.WriteLine("Hello, World!");
    }

    public static void PrintDataTablePersoneSelect(DataTable dt)
    {
        foreach (DataRow dr in dt.Select("ID in (285,38,121)", "Nombre"))
        {
            Console.WriteLine($"ID:{dr["ID"]}; Nombre:{dr["Nombre"]}; Incial:{dr["Inicial"]}; Apellidos:{dr["Apellidos"]}; ");
        }
    }

    public static void PrintDataTablePersone(DataTable dt)
    {
        foreach (DataRow dr in dt.Rows)
        {
            Console.WriteLine($"ID:{dr["ID"]}; Nombre:{dr["Nombre"]}; Incial:{dr["Inicial"]}; Apellidos:{dr["Apellidos"]}; ");
        }
    }
    public static void SemiAutomatico()
    {
        using (SqlConnection conexion = new SqlConnection("Persist Security Info=true;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019"))
        {
            DataSet ds = new DataSet();

            DataTable personas = new DataTable("Personas");
            ds.Tables.Add(personas);

            DataColumn idPersona = new DataColumn("ID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
            };

            personas.Columns.Add(idPersona);

            personas.PrimaryKey = new[] { idPersona };

            DataColumn nombre = personas.Columns.Add("Nombre", typeof(string));
            nombre.MaxLength = 50;
            nombre.AllowDBNull = false;

            DataColumn inicial = personas.Columns.Add("Inicial", typeof(string));
            inicial.MaxLength = 50;
            inicial.AllowDBNull = true;

            DataColumn apellidos = personas.Columns.Add("Apellidos", typeof(string));
            inicial.MaxLength = 50;
            inicial.AllowDBNull = true;

            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT TOP 15 BusinessEntityID, FirstName, Middlename, LastName FROM Person.Person", conexion);
            //adaptador.SelectCommand = new SqlCommand("SELECT TOP 15 BusinessEntityID, FirstName, Middlename, LastName FROM Person.Person", conexion);

            DataTableMapping mapeo = new DataTableMapping("Table", "Personas");
            mapeo.ColumnMappings.Add("BusinessEntityID", "ID");
            mapeo.ColumnMappings.Add("FirstName", "Nombre");
            mapeo.ColumnMappings.Add("Middlename", "Inicial");
            mapeo.ColumnMappings.Add("LastName", "Apellidos");

            adaptador.TableMappings.Add(mapeo);

            adaptador.Fill(ds);

            AddNewPerson(ds.Tables[0], "Pepito", "Grillo");


            PrintDataTablePersone(ds.Tables["Personas"]);
            //PrintDataTablePersoneSelect(ds.Tables[0]);

            ds.Tables["Personas"].AcceptChanges();
            //ds.Tables["Personas"].RejectChanges(); --deshacer

            //GuardarDatosEnDB

            //adaptador.InsertCommand = null;
        }
    }



    public static void AddNewPerson(DataTable dt, string nNombre, string nApellido, string nInicial = null)
    {
        var newRow = dt.NewRow();
        newRow["Nombre"] = nNombre;
        newRow["Apellidos"] = nApellido;
        newRow["Inicial"] = nInicial;

        dt.Rows.Add(newRow);      
    }

    public static void Automatico()
    {
        using (SqlConnection conexion = new SqlConnection("Persist Security Info=true;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019"))
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT TOP 15 BusinessEntityID, FirstName, Middlename, LastName FROM Person.Person", conexion);
            //adaptador.SelectCommand = new SqlCommand("SELECT TOP 15 BusinessEntityID, FirstName, Middlename, LastName FROM Person.Person", conexion);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Personas");

            // mapeo opcional



        }
    }

    public static void Manual()
    {
        using (SqlConnection conexion = new SqlConnection("Persist Security Info=true;Integrated Security=True;Initial Catalog=AdventureWorks2019;Server=BPO2204-408\\SQL2019"))
        {
            DataSet ds = new DataSet();

            DataTable personas = new DataTable("Personas");
            ds.Tables.Add(personas);

            DataColumn idPersona = new DataColumn("ID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
            };

            personas.Columns.Add(idPersona);

            personas.PrimaryKey = new[] { idPersona };

            DataColumn nombre = personas.Columns.Add("Nombre", typeof(string));
            nombre.MaxLength = 50;
            nombre.AllowDBNull = false;

            DataColumn inicial = personas.Columns.Add("Inicial", typeof(string));
            inicial.MaxLength = 50;
            inicial.AllowDBNull = true;

            DataColumn apellidos = personas.Columns.Add("Apellidos", typeof(string));
            inicial.MaxLength = 50;
            inicial.AllowDBNull = true;


            SqlCommand cmdCount = new SqlCommand("SELECT TOP 15 BusinessEntityID, FirstName, Middlename, LastName FROM Person.Person", conexion);


        }
    }

}