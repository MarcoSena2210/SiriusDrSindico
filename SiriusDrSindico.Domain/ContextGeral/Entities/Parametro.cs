using System;
using FluentValidator;
using FluentValidator.Validation;
using SiriusDrSindico.Domain.ContextGeral.Enums;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Parametro :Notifiable
    {
            public Parametro(Guid condominioId, Guid edificacaoId,
            byte numeroDeImoveisPorEdificio,
            byte diaVencimentoBoleto, 
            byte diaParaDesconto,
            ETipoCondominio tipoCondominio, ETipoJuro tipoJuro, 
            ETipoMulta tipoMulta,ETipoDesconto tipoDesconto, decimal percentuaJuro,
            decimal percentuaMulta, decimal percentuaFundoReserva, 
            decimal percentuaDesconto, decimal valorCondominio,
            decimal valorDesconto, decimal valorMulta, 
            decimal valorFundoReserva)
        {
            CondominioId = condominioId;
            EdificacaoId = edificacaoId;
            NumeroDeImoveisPorEdificio = numeroDeImoveisPorEdificio;
            DiaVencimentoBoleto = diaVencimentoBoleto;
            DiaParaDesconto = diaParaDesconto;
            TipoCondominio = tipoCondominio;
            TipoJuro = tipoJuro;
            TipoMulta = tipoMulta;
           // TipoFundoReserva = tipoFundoReserva;
            TipoDesconto = tipoDesconto;
            PercentuaJuro = percentuaJuro;
            PercentuaMulta = percentuaMulta;
            PercentuaFundoReserva = percentuaFundoReserva;
            PercentuaDesconto = percentuaDesconto;
            ValorCondominio = valorCondominio;
            ValorDesconto = valorDesconto;
            ValorMulta = valorMulta;
            ValorFundoReserva = valorFundoReserva;

            AddNotifications(new ValidationContract()
                .Requires()
                .AreEquals(ValorCondominio,0, "decimal", "Informe o valor do condominio")
                .IsGreaterThan(ValorCondominio, ValorDesconto, "decimal", "O Valor do desconto não pode ser maior que o valor do condominio ")
            );

           // new AddNotifications<Parametro>(Parametro)
           //      .IfNotGuid(x =>x.CondominioId,"Informe um id do condominio GUID"); 

          //       .IfNotGuid(x =>x.EdificacaoId,"informe um id da edificacao GUID"); 
                          
        }
#region Propriedades
        public Guid CondominioId { get; private set; }
        public Guid EdificacaoId { get; private set; }
        public byte NumeroDeImoveisPorEdificio { get; private set; }
        public byte DiaVencimentoBoleto { get; private set; }
        public byte DiaParaDesconto { get; private set; }

        public ETipoCondominio TipoCondominio { get; private set; }
        public ETipoJuro TipoJuro { get; private set; }
        public ETipoMulta TipoMulta { get; private set; }
        //public ETipoFundoReserva TipoFundoReserva { get; private set; }
        public ETipoDesconto TipoDesconto { get; private set; }

        public decimal PercentuaJuro { get; private set; }
        public decimal PercentuaMulta { get; private set; }
        public decimal PercentuaFundoReserva { get; private set; }
        public decimal PercentuaDesconto { get; private set; }
        public decimal ValorCondominio { get; private set; }
        public decimal ValorDesconto { get; private set; }
        public decimal ValorMulta { get; private set; }
        public decimal ValorFundoReserva { get; private set; }
#endregion

     

       
    }
}
