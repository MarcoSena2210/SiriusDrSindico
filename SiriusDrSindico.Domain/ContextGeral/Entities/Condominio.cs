using System;
using System.Linq;
using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Condominio : Notifiable
    {
         //Cria uma lista para adionar as edificações 
        private readonly IList<Edificacao> _edificacoes;
        public Condominio(Empresa empresa,VNome nomeCondominio, VEmail email, VEndereco endereco)
        {
            IdCondominio = Guid.NewGuid().ToString().Replace("-"," ").Substring(0,8).ToUpper();
            Empresa = empresa;
            NomeCondominio = nomeCondominio;
            Email = email;
            DataCadastro = DateTime.Now;
            Endereco = endereco;
             //A passagem da lista
             _edificacoes = new List<Edificacao>() ;

              AddNotifications(new ValidationContract()
                .Requires()
           
            );    
        }

        #region Propriedades
        public string IdCondominio { get; private set; }
     
        public VNome NomeCondominio { get; private set; }
        public VEmail Email { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public VEndereco Endereco { get; private set; }

        /*EF propriedades de navegacao-RELACIONAMENTOS  1 Condominio pertence a uma empresa */
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        // EF Propriedade de Navegação
        public ICollection<Edificacao> Edificacoes  => _edificacoes.ToArray();
        #endregion

        #region Métodos

        public void AddEdificacoes(Edificacao edificacao)
        {
            //Validar Condominio
            //Adicionar CondominioV
            _edificacoes.Add(edificacao);
        }




        public override string ToString()
        {
            var e = "Nome :" + NomeCondominio
                     + "Email :" + Email
                     + Endereco.ToString();
            return e;
        }
        #endregion
    }
}