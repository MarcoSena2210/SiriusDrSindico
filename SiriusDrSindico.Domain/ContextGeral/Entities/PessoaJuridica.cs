using System;
using System.Collections.Generic;
using System.Text;
using MeuSindicoMS.Domain.ValueObjects;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class PessoaJuridica : Pessoa
    {
        protected PessoaJuridica(VNome nome, VCPFouCNPJ documento, VEmail email,VEndereco endereco)
                          : base(nome, documento, email )
        {
        }

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
