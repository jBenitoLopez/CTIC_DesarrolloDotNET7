using System;

namespace modelos_ampliacion
{
    public class Alumno : Persona, IContribuyente<int>, IComparable
    {
        public int Referencia { get; set; }
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }
        public int Nota { get; set; } = 0;

        public override void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }

        public void PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        public int CompareTo(object obj)
        {
            if (obj is Alumno)
            {
                Alumno alumno = (Alumno)obj;
                return string.Compare(this.Apellidos + ", " + this.Nombre, alumno.Apellidos + ", " + alumno.Nombre);
            }
            else
            {
                return 0;
            }
        }

        // Clase Alumno
        public override void Deconstruct(out TipoPersona tipoPersona, out string asignatura)
        {
            tipoPersona = TipoPersona;
            asignatura = Aula;
        }
    }
}