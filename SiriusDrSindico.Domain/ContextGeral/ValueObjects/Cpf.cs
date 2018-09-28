using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.ValueObjects
{
    public class Cpf
    {
        public string ValorCpf { get; private set;}

        public Cpf(string valorCpf)
        {
            ValorCpf = valorCpf;
        }

        private static bool IsCpf(string valorcpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            valorcpf = valorcpf.Trim().Replace(".", "").Replace("-", "");
            if (valorcpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == valorcpf)
                    return false;

            string tempCpf = valorcpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return valorcpf.EndsWith(digito);
        }
    }
}
