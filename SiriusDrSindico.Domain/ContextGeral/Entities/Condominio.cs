using System;
using System.Collections.Generic;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Condominio
    {
        public Condominio(VNome nome, VEmail email, DateTime dataCadastro, VEndereco endereco)
        {
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
            Endereco = endereco;
            //Instanceiar aqui verificar  ICollection<Edificacao> Edificacoes { get; set; }
        }

        #region Propriedades
        public int IdCondominio { get; private  set; }
        public VNome Nome { get; private set; }
        public VEmail Email { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public VEndereco Endereco { get; private set; }
        
         /*EF propriedades de navegacao-RELACIONAMENTOS  1 Condominio pertence a uma empresa */
         public int  EmpresaId { get; set; }
         public Empresa Empresa { get; set; }


        // EF Propriedade de Navegação
        public ICollection<Edificacao> Edificacoes { get; set; }
        #endregion

        public override string ToString()
        {
            var e = "Nome :" + Nome 
                     + "Email :" +Email
                     + Endereco.ToString() ;
            return e;
        }
    }
}