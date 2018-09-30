using FluentValidator;
using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextGeral.ValueObjects
{
    public class VEndereco : Notifiable
    {
        public VEndereco(string logradouro, string numero, string complemento, string bairro, string uf, string cidade, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Uf = uf;
            Cidade = cidade;
            Cep = cep;
            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Logradouro, 5, "Logradouro", "O logradouro deve conter pelo menos 3 caracteres")
                .HasMaxLen(Logradouro, 40, "Logradouro", "O logradouro deve conter no máximo 40 caracteres")
                .HasMinLen(Numero, 3, "Numero", "O número deve conter pelo menos 3 caracteres")
                .HasMaxLen(Numero, 10, "Numero", "O número deve conter no máximo 10 caracteres")
                .HasMinLen(Bairro, 5, "Bairro", "O bairro deve conter pelo menos 3 caracteres")
                .HasMaxLen(Bairro, 40, "Bairro", "O bairro deve conter no máximo 40 caracteres")
                .HasMinLen(Uf, 2, "Uf", "A Uf deve conter pelo menos 3 caracteres")
                .HasMinLen(Cidade, 5, "Cidade", "A cidade deve conter pelo menos 5 caracteres")
                .HasMaxLen(Cidade, 40, "Cidade", "A cidade deve conter no máximo 40 caracteres")
                .HasMinLen(Cep, 8, "Cep", "O Cep deve conter pelo menos 8 caracteres")
            );    


        }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public override string ToString()
        {
            var e = "Logradouro :" + Logradouro
                     + "Numero :" + Numero
                     + "Complemento :" + Complemento
                     + "Bairro :" + Bairro
                     + "Uf :" + Uf
                      + "Cidade :" + Cidade
                     + "Cep :" + Cep;
            return e;
        }
    }
}