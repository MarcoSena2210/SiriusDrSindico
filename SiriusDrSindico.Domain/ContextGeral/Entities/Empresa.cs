using System;
using System.Linq;
using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;
using FluentValidator.Validation;
using FluentValidator;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Empresa : Notifiable
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
            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(RazaoSocial, 3, "RazaoSocial", "A RazaoSocial deve conter pelo menos 3 caracteres")
                .HasMaxLen(RazaoSocial, 50, "RazaoSocial", "A RazaoSocial deve conter no máximo 50 caracteres")
            );    

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