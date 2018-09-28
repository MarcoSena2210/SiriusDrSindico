using System;
using DrSindico.Domain.Enums;

namespace SiriusDrSindico.Domain.ContextFinanceiro.AReceber.Entities
{
    public class Mensalidade
    {
        public Mensalidade(string numero, int anoRef, int mesRef, Guid imovelId, Decimal valorMensal, Decimal valorPago, DateTime dataVencimento, DateTime dataPagamento, DateTime datainclusao, EStatusMensalidade statusMensalidade)
        {
            this.Numero = numero;
            this.AnoRef = anoRef;
            this.MesRef = mesRef;
            this.ImovelId = imovelId;
            this.ValorMensal = valorMensal;
            this.ValorPago = valorPago;
            this.DataVencimento = dataVencimento;
            this.DataPagamento = dataPagamento;
            this.Datainclusao = datainclusao;
            this.StatusMensalidade = statusMensalidade;

        }
       #region Propriedade
        public string Numero { get; private set; }
        public int AnoRef { get; private set; }
        public int MesRef { get; private set; }
        public Guid ImovelId { get; private set; }
        public Decimal ValorMensal { get; private set; }
        public Decimal ValorPago { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime Datainclusao { get; private set; }
        public EStatusMensalidade StatusMensalidade { get; private set; }
        #endregion

        #region Metodos
        public void GerarMensalidade(){} 
        public void CalcularMensalidade(){}
         
        #endregion
    }
}