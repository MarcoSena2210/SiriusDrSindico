using System;

namespace SiriusDrSindico.Domain.ContextGeral.ValueObjects
{
    public abstract class VPeriodo
    {
        protected VPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }


        #region Propriedade
        public DateTime DataInicial { get; private set; }    
        public DateTime DataFinal { get; private set; }    
        #endregion   

        #region Método
            //
            
        #endregion
    }
}