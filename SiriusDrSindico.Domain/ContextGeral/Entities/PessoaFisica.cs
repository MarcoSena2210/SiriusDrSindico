using System;
using MeuSindicoMS.Domain.ValueObjects;
using SiriusDrSindico.Domain.ContextGeral;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class PessoaFisica : Pessoa
    {
        protected PessoaFisica(VNome nome, VCPFouCNPJ documento, VEmail email) : base(nome, documento, email)
        {
        }

        public string Telefone { get; private set; }
        public DateTime DataNascimento { get; private set; }


        //public override bool EhValido()
        //{
        //    Validar();
        //    return ValidationResult.IsValid;
        //}

        //#region Validações
        //private void Validar()
        //{
         
        //    ValidationResult = Validate(this);

        //    // Validacoes adicionais 
        //    //ValidarEndereco();
        //}

      
        //#endregion
    }
}
