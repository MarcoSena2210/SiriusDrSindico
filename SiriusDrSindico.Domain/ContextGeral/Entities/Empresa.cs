using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Empresa
    {
        public Empresa(VNome nome, string razaoSocial, string telefone, VEmail email, VEndereco endereco)
        {
            Nome = nome;
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }

#region Método
    
        public VNome Nome {get; private set;} 
        public string RazaoSocial { get; private set; }
        public string Telefone { get; private set; }
        public VEmail Email { get; private set; }
        public VEndereco Endereco { get; private set; }
        public IList<Condominio> Condominios { get;  set; }

#endregion




        public override string ToString()
        {
            var e = "Nome :" + Nome 
                     + "RazaoSocial :" + RazaoSocial 
                     + "Telefone :" + Telefone 
                     + "Email :" +Email
                     + Endereco.ToString() ;
            return e;
        }
        
    }
}