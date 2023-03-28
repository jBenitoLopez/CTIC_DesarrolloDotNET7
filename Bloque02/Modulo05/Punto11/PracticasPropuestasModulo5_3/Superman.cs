namespace PracticasPropuestasModulo5_3
{
    public class Superman : IAvion, IPajaro
    {
        public void Volar()
        {
            if (this is IAvion)
                Console.WriteLine("Volando is un Avion !");

            if (this is IPajaro)
                Console.WriteLine("Volando is un Pajaro !");

            if (this is Superman)
                Console.WriteLine("Volando is un Superman !");


            Type type = this.GetType();
            if (type == typeof(IAvion))
            {
                Console.WriteLine("Volando como typeof Avion !");
            }
            else if (type == typeof(IPajaro))
            {
                Console.WriteLine("Volando como typeof Pajaro !");
            }
            else
            {
                Console.WriteLine("Volando como typeof Superman !");
            }
        }

        public void Aletear()
        {
            Console.WriteLine("Aleteando !");
        }

    }

}