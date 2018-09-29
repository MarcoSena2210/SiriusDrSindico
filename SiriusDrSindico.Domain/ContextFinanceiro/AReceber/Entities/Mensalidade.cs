using System;
using DrSindico.Domain.Enums;

namespace SiriusDrSindico.Domain.ContextFinanceiro.AReceber.Entities
{
    public class Mensalidade
    {
        public Mensalidade(Guid imovelId, Decimal valorMensal, Decimal? valorPago, DateTime? dataPagamento )
        {
            this.NumeroMensalidade = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
            this.AnoRef = DateTime.Now.Year;
            this.MesRef = DateTime.Now.Month;
            this.ImovelId = imovelId;
            this.ValorMensal = valorMensal;
            this.SetValorPago(0.0M);
            this.DataVencimento = DateTime.Now.AddMonths(1);
            this.DataPagamento = null;
            this.DataPagamento =dataPagamento;
            this.Datainclusao = DateTime.Now;
            this.StatusMensalidade = EStatusMensalidade.Aberto;

        }
    #region Propriedade
        public  string NumeroMensalidade { get; private set; }
        public int AnoRef { get; private set; }
        public int MesRef { get; private set; }
        public Guid ImovelId { get; private set; }
        public Decimal ValorMensal { get; private set; }
        private decimal? valorPago;
        public DateTime DataVencimento { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public DateTime Datainclusao { get; private set; }
        public EStatusMensalidade StatusMensalidade { get; private set; }
    #endregion

    #region Metodos
        private void SetValorPago(decimal? value)
        {
            valorPago = value;
        }
        public decimal? GetValorPago()
        {
            return valorPago;
        }
        public void GerarMensalidade(){} 
        public void CalcularMensalidade(){}
         
    #endregion
    }
}