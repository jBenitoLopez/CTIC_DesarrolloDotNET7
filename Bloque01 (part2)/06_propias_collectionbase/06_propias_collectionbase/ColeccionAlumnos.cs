using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_propias_collectionbase
{
    public class ColeccionAlumnos: System.Collections.CollectionBase
    {
        public int Add(Alumno alumno)
        {
            return List.Add(alumno); //(IList, pasa por el OnInsert)
            //return InnerList.Add(alumno); //(ArrayList, NO pasa por el OnInsert)
        }

        public void Insert(int index, Alumno alumno)
        {
            List.Insert(index, alumno); //(IList, pasa por el OnInsert)
            //InnerList.Insert(index,alumno); //(ArrayList, NO pasa por el OnInsert)
        }

        public void Remove(Alumno alumno)
        {
            List.Remove(alumno); //(IList, pasa por el OnInsert)
            //InnerList.Remove(alumno); //(ArrayList, NO pasa por el OnInsert)
        }

        public void Sort() { 
            //InnerList.Sort(); //(ArrayList, NO pasa por el OnInsert)
        }

        public Alumno this[int index]
        {
            get
            {
                return (Alumno)List[index];
            }
            set
            {
                List[index] = value;
            }
            
        }

        protected override void OnInsert(int index, object? value)
        {
            Console.WriteLine("Se paso por el OnInsert");
            base.OnInsert(index, value);
        }

    }
}
