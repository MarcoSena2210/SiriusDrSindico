namespace SiriusDrSindico.Domain.ContextGeral.ValueObjects
{
    public class VEndereco
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