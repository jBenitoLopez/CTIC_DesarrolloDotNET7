namespace PracticaModulo6
{
    public class Comparar5<T>
    {

        public T Param1 { get; set; }
        public T Param2 { get; set; }

        public Comparar5()
        {

        }
        public Comparar5(T param1, T param2)
        {
            Param1 = param1;
            Param2 = param2;
        }

        public bool Igualdad()
        {
            return Param1.Equals(Param2);
        }

        public string Mostrar()
        {

            if (Param1 is Conserje param1c && Param2 is Conserje param2c)
            {
                // var param1 = Param1 as Conserje;
                // var param2 = Param2 as Conserje;
                return $"Item1: {param1c.Nombre} {param1c.Apellidos}, Item2: {param2c.Nombre} {param2c.Apellidos}";
            }
            else if (Param1 is Profesor param1p && Param2 is Profesor param2p)
            {
                return $"Item1: {param1p.Nombre} {param1p.Apellidos}, Item2: {param2p.Nombre} {param2p.Apellidos}";
            }
            else if (Param1 is int param1i && Param2 is int param2i)
            {
                return $"Item1: {param1i}, Item2: {param2i}. La suma es {param1i + param2i}";
            }
            else if (Param1 is string param1s && Param2 is string param2s)
            {
                return $"Item1: {param1s}, Item2: {param2s}. Concadenado seria {param1s + param2s}";
            }

            return null;
        }
    }
}