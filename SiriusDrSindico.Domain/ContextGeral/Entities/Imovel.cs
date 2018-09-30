using FluentValidator;
using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextGeral.Entities
{
    public class Imovel : Notifiable
    {
        public Imovel(Edificacao edificacao,string identificadorImovel, string sigla, string numero)
        {
            Edificacao = edificacao;
            IdentificadorImovel = identificadorImovel;
            Sigla = sigla;
            Numero = numero;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(identificadorImovel, 6, "identificadorImovel", "O identificadorImovel deve conter pelo menos 6 caracteres")
                .HasMaxLen(identificadorImovel, 10, "identificadorImovel", "O identificadorImovel deve conter no máximo 10 caracteres")
                .HasMinLen(Numero, 3, "Numero", "O número deve conter pelo menos 3 caracteres")
                
            );    

        }
        #region Propriedades
        public string IdentificadorImovel { get; private set; } //not null  
        public string Sigla { get; private set; } //AP-apatamento;TR-Terreno;GA-Garagem;QD=Quadra;PI=Piscina;CA=CASA;LO=Loja
        public string Numero { get; private set; }  
        
         /*EF propriedades de navegacao-RELACIONAMENTOS  1 Imovelo pertence a uma edificacao */
        public string EdificacaoId { get; set; }
        public Edificacao Edificacao { get; set; }

        #endregion 

        #region Métodos
        public override string ToString()
        {
            var e = "Imovel :" + IdentificadorImovel;
            return e;
        }
        #endregion
    }
}