using System.Collections.Generic;
using System.Linq;
using MeuSindicoMS.Domain.ValueObjects;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public abstract class Pessoa //:Entity 
    {
        //Criamos uma lista interna, privada
        private readonly IList<Endereco> _enderecos;    
        protected Pessoa()   {  }

        protected Pessoa(VNome nome, VCPFouCNPJ documento, VEmail email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            //A passagem da lista
            _enderecos = new List<Endereco>();
        }
        #region  Proprieddes

        public VNome Nome { get; private set; }
        public VCPFouCNPJ Documento { get; private set; }
        public VEmail Email { get; private set; }
        //public IReadOnlyCollection<Endereco> Enderecos { get; {return _enderecos.ToArray(); } }
        // pode ser como abaixo.
        //  retorno da lista está na expressão " => _enderecos.ToArray()" que é convertida em um array
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray();
   

        #endregion

        #region Métodos

        /* Adiciona Endereços  */
        public void AddEndereco(Endereco endereco){
            //Validar o endereço
            //Adionar o endereco
            _enderecos.Add(endereco);

        }


        public override string ToString()
        {
            {
                var p = "Pessoa : " + Nome + "Documento : " + Documento.Numero + "-" + Documento.GetType();
                return p;
            }
        }
        #endregion       
    }

}
