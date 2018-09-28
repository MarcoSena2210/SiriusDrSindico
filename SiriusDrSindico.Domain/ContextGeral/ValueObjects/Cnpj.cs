using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.ValueObjects
{
    public class Cnpj
    {
        public string ValorCnpj { get; private set;}


        public Cnpj() {  }

        public Cnpj(string valorCnpj)
        {
            ValorCnpj = valorCnpj;
        }

        private static bool IsCnpj(string valorCnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            valorCnpj = valorCnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (valorCnpj.Length != 14)
                return false;

            string tempCnpj = valorCnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return valorCnpj.EndsWith(digito);
        }



    }
}
