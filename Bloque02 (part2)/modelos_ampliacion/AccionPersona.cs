namespace modelos_ampliacion
{
    class AccionPersona<TReferencia, TPersona>
        where TReferencia : struct
        where TPersona : IContribuyente<TReferencia>
    {
        private TReferencia referencia = default(TReferencia);

        
        //public TReferencia Referencia
        //{
        //    get
        //    {
        //        return referencia;
        //    }
        //    set
        //    {
        //        referencia = value;
        //    }
        //}

        // Usando miembros con cuerpo de expresión
        public TReferencia Referencia
        {
            get => referencia;    
            set => referencia = value;
        }


        public TPersona Persona { get; set; }

        public bool EsIgual(TPersona OtraPersona)
        {
            if (OtraPersona.Equals(Persona))
            {
                return true;
            }
            else
            {
                if (Persona.Nombre == OtraPersona.Nombre
                    && Persona.Apellidos == OtraPersona.Apellidos)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}