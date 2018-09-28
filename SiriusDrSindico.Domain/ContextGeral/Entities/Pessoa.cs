using MeuSindicoMS.Domain.ValueObjects;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public abstract class Pessoa //:Entity 
    {
        protected Pessoa()
        {
        }

        protected Pessoa(VNome nome, VCPFouCNPJ documento, VEmail email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
        }

        public VNome Nome { get; private set; }
        public VCPFouCNPJ Documento { get; private set; }
        public VEmail Email { get; private set; }

        public override string ToString()
        {
            {
                var p = "Pessoa : " + Nome + "Documento : " + Documento.Numero + "-" + Documento.GetType();
                return p;
            }
        }
    }

}
