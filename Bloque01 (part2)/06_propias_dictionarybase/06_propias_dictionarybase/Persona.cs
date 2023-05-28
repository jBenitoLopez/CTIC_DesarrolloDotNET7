using System;
using System.Xml.Serialization;

namespace _06_propias_dictionarybase
{
    public enum TipoPersona : byte
    {
        Alumno = 1,
        Profesor = 2,
        Rector = 4,
        Secretario = 8,
        Conserje = 16,
        Vigilante = 32
    }

    public delegate void DatosCambiadosEventHandler(string NombreProp, string ValorAnterior, string ValorNuevo);

    public class Persona
    {
        public event DatosCambiadosEventHandler DatosCambiados;

        private DateTime fechaNacimiento;

        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                string nombreAnterior = nombre;
                nombre = value;

                if (DatosCambiados != null)
                {
                    DatosCambiados("Nombre", nombreAnterior, nombre);
                }
            }
        }
        private string apellidos;
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                string apellidosAnteriores = apellidos;
                apellidos = value;

                if (DatosCambiados != null)
                {
                    DatosCambiados("Apellidos", apellidosAnteriores, apellidos);
                }
            }
        }

        public DateTime FechaNacimiento
        {
            set
            {
                if (value < DateTime.Today)
                {
                    fechaNacimiento = value;
                }

                if (DatosCambiados != null)
                {
                    DatosCambiados("FechaNacimiento", "No disponible", "No disponible");
                }
            }
        }

        public int Edad
        {
            get
            {
                return (int)(DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
            }
        }

        public TipoPersona TipoPersona { get; set; }

        public Persona() { }

        public Persona(string Nombre, string Apellidos, DateTime FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
        }

        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }
}