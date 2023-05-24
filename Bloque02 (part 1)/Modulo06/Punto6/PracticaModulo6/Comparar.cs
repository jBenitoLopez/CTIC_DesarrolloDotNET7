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

        public string Mostrar()
        {


            return $"Item1: {Param1.Nombre} {Param1.Apellidos}, Item2: {Param2.Nombre} {Param2.Apellidos}";
        }
    }
}