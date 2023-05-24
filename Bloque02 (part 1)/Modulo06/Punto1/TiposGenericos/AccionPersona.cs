namespace TiposGenericos
{
    class AccionPersona<TPersona, TReferencia>
        where TReferencia : struct
        where TPersona : IContribuyente
    {
        private TReferencia RefInterna = default(TReferencia);
        public TReferencia Referencia { get; set; }
        public TPersona Persona { get; set; }
        public bool EsIgual(TPersona OtraPersona)
        {
            return OtraPersona.Equals(Persona);
        }
    }

}