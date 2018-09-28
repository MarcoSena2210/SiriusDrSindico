using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Edificacao
    {
        public Edificacao(VNome nome, VEndereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public VNome Nome {get; private set;} 
        public VEndereco Endereco { get; private set; }

        public override string ToString()
        {
            var e = "Nome :" + Nome 
                     + Endereco.ToString() ;
            return e;
        }
    }
}