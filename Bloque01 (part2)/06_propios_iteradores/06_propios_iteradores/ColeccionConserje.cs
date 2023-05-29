using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_propios_iteradores
{
    // Clase de tipo Generica (IEnumerable<Conserje>)
    public class ColeccionConserje : IEnumerable<Conserje>
    {
        private Conserje[] conserjes;

        public ColeccionConserje(Conserje[] conserjes)
        {
            this.conserjes = conserjes;
        }

        // Implementacion Generia 
        public IEnumerator<Conserje> GetEnumerator()
        {
            for (int i = 0; i < conserjes.Length; i++)
            {
                yield return conserjes[i];
            }
        }

        // Implementacion de tipo Object
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // Clase de tipo Object (IEnumerable)
    public class ColeccionConserjeObj : IEnumerable
    {
        // Implementacion tipo Object 
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
