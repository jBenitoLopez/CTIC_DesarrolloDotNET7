using System;

namespace DEMO_PoniedoTuplasATrabajar
{
    public class Alumno : Persona, IContribuyente<int>, IComparable, IDisposable
    {
        public int Referencia { get; set; }
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }

        //public override void MostrarNombre()
        //{
        //    Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        //}

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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}