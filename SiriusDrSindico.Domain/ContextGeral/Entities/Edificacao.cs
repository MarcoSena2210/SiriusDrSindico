using System.Linq;
using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Edificacao :Notifiable
    {
        //Cria uma list aprivada para adionar os imoveis dessa edificacao
        private readonly IList<Imovel> _imoveis;
         
        public Edificacao(Condominio condominio, VNome nomeEdificacao, VEndereco endereco)
        {   
            Condominio = condominio;
            NomeEdificacao = nomeEdificacao;
            Endereco = endereco;
             //A passagem da lista
            _imoveis = new List<Imovel>();
             AddNotifications(new ValidationContract()
                .Requires()
                 );
        }

        #region Proipriedades
        public VNome NomeEdificacao {get; private set;} 
        public VEndereco Endereco { get; private set; }
            
        /*EF propriedades de navegacao-RELACIONAMENTOS  1 Condominio pertence a uma empresa */
        public string CondominioId { get; set; }
        public Condominio Condominio { get; set; }

        // EF Propriedade de Navegação
        public ICollection<Imovel> Imoveis => _imoveis.ToArray();
        #endregion

        #region Métodos

        /* Adiciona imoveis a lista em edificações   */
        public void AddImoveis(Imovel imovel){
            //Validar o endereço
            //Adionar o endereco
            _imoveis.Add(imovel);
        }


        public override string ToString()
        {
            var e = "Nome :" + NomeEdificacao 
                     + Endereco.ToString() ;
            return e;
        }
        #endregion
    }
}