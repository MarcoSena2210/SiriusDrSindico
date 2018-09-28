namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Imovel
    {
        public Imovel(string identificadorImovel, string sigla, string numero)
        {
            IdentificadorImovel = identificadorImovel;
            Sigla = sigla;
            Numero = numero;
        }
        #region Propriedades
        public string IdentificadorImovel { get; private set; } //not null  
        public string Sigla { get; private set; } //AP-apatamento;TR-Terreno;GA-Garagem;QD=Quadra;PI=Piscina;CA=CASA;LO=Loja
        public string Numero { get; private set; }  
        
        /* Propriedade de relacionamento e mapeamento EF */
        // public Guid EdificacaoId { get; private set; }
        // public Edificacao Edificacao { get; private set; }
        #endregion 

        public override string ToString()
        {
            var e = "Imovel :" + IdentificadorImovel;
            return e;
        }
    }
}