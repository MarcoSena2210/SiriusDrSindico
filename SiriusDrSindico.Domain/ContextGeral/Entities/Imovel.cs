namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Imovel
    {
        public Imovel(Edificacao edificacao,string identificadorImovel, string sigla, string numero)
        {
            Edificacao = edificacao;
            IdentificadorImovel = identificadorImovel;
            Sigla = sigla;
            Numero = numero;
        }
        #region Propriedades
        public string IdentificadorImovel { get; private set; } //not null  
        public string Sigla { get; private set; } //AP-apatamento;TR-Terreno;GA-Garagem;QD=Quadra;PI=Piscina;CA=CASA;LO=Loja
        public string Numero { get; private set; }  
        
         /*EF propriedades de navegacao-RELACIONAMENTOS  1 Imovelo pertence a uma edificacao */
        public string EdificacaoId { get; set; }
        public Edificacao Edificacao { get; set; }

        #endregion 


        public override string ToString()
        {
            var e = "Imovel :" + IdentificadorImovel;
            return e;
        }
    }
}