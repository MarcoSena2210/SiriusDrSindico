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
         
        public Edificacao(Condominio condominio, string nomeEdificacao, VEndereco endereco)
        {   
            Condominio = condominio;
            NomeEdificacao = nomeEdificacao;
            Endereco = endereco;
             //A passagem da lista
            _imoveis = new List<Imovel>();
             AddNotifications(new ValidationContract()
                     .Requires()
                     .HasMinLen(NomeEdificacao, 3, "NomeEdificacao", "O nome do condominio deve conter pelo menos 3 caracteres")
                     .HasMaxLen(NomeEdificacao, 50, "NomeEdificacao", "O nome do condominio deve conter no máximo 50 caracteres")
              );
        }

        #region Proipriedades
        public string NomeEdificacao {get; private set;} 
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