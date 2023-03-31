using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaModulo6
{
    public class Comparar<T>
        where T : IComparar
    {

        public T Param1 { get; set; }
        public T Param2 { get; set; }

        public bool Igualdad()
        {
            return Param1.Equals(Param2);
        }
    }
}