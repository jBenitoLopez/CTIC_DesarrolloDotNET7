namespace usando_linq
{
    class AccionPersona<TReferencia, TPersona>
        where TReferencia : struct
        where TPersona : IContribuyente<TReferencia>
    {
        private TReferencia referencia = default(TReferencia);
        public TReferencia Referencia
        {
            get
            {
                return referencia;
            }
            set
            {
                referencia = value;
            }
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