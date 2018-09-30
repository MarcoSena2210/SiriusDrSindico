using System;
using System.Linq;
using System.Collections.Generic;
using DrSindico.Domain.Enums;

namespace SiriusDrSindico.Domain.ContextFinanceiro.AReceber.Entities
{
    public class Mensalidade
    {
         
        private readonly IList<Mensalidade> _mensalidades;
         private readonly IList<Mensalidade> _pagamentos;
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
            _mensalidades= new List<Mensalidade>() ;
            _pagamentos = new List<Mensalidade>();
           // this.StatusMensalidade = EStatusMensalidade.Aberto;

        }
    #region Propriedade
        public  string NumeroMensalidade { get; private set; }
        public int AnoRef { get; private set; }
        public int MesRef { get; private set; }
        public Guid ImovelId { get; private set; }
        public Decimal ValorMensal { get; private set; }
        private decimal? ValorPago { get; set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public DateTime Datainclusao { get; private set; }
        public EStatusMensalidade StatusMensalidade { get; private set; }

         public IReadOnlyCollection<Mensalidade> mensalidades => _mensalidades.ToArray();
          public IReadOnlyCollection<Mensalidade> pagamentos => _pagamentos.ToArray();
    #endregion

    #region Metodos

      

        //Criar uma mensalidade
        public void addMensalidade(Mensalidade mensalidade){
            mensalidade.Aberta();  
            _mensalidades.Add(mensalidade);
         }    
        
        //Pagar mensalidade
        public void EfetuarPagamentoMensalidade(Mensalidade mensalidade){
            mensalidade.Paga();      
            _pagamentos.Add(mensalidade);
        }

        public void Aberta(){
             this.StatusMensalidade = EStatusMensalidade.Aberto;  
        } 

        public void Paga(){
             this.StatusMensalidade = EStatusMensalidade.Pago;  
        } 
        //Canelar um pagamento
        public void Cancelada(string numeroMensalidade){
            //TO-DO:Se já foi pago, nao pode cancelar  
             this.StatusMensalidade = EStatusMensalidade.Cancelada;  
             
            //if(_pagamentos.Contains(umeroMensalidade)); 
            //  _pagamentos.ToList().ForEach(p => p.Cancelada());


        }

        //Gerar recibo


         


        //Estornar um mensalidade, que ainda não foi paga

        private void SetValorPago(decimal value)
        {
            this.ValorMensal = value;
        }
        public decimal? GetValorPago()
        {   
            return this.ValorMensal;
        }
        public void GerarMensalidade(){} 
        public void CalcularMensalidade(){}
         
    #endregion
    }
}