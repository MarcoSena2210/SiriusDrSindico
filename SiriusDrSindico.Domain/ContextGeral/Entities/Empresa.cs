using System;
using System.Linq;
using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Empresa
    {
        //Cria uma lista para adionalr os condominio
        private readonly IList<Condominio> _condominios;
        public Empresa(VNome nome, string razaoSocial, string telefone, VEmail email, VEndereco endereco)
        {
            IdEmpresa = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            Nome = nome;
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
             //A passagem da lista
            _condominios = new List<Condominio>(); 
        }

        #region Propriedades
    
        public string IdEmpresa   {get; private set;} 
        public VNome Nome {get; private set;} 
        public string RazaoSocial { get; private set; }
        public string Telefone { get; private set; }
        public VEmail Email { get; private set; }
        public VEndereco Endereco { get; private set; }
        //public IReadOnlyCollection<Endereco> Enderecos { get; {return _enderecos.ToArray(); } }
        // pode ser como abaixo.
        //  retorno da lista está na expressão " => _enderecos.ToArray()" que é convertida em um array
        public IReadOnlyCollection<Condominio> Condominios => _condominios.ToArray();

        #endregion

        #region Método
   
        public void AddCondominio(Condominio condominio)
        {
            //Validar Condominio
            //Adicionar CondominioV
            _condominios.Add(condominio);
        }


        public override string ToString()
        {
            var e = "Nome :" + Nome.ToString() 
                     + "RazaoSocial :" + RazaoSocial 
                     + "Telefone :" + Telefone 
                     + "Email :" +Email
                     + Endereco.ToString() ;
            return e;
        }
        #endregion
    }
}