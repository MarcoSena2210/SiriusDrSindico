using System;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Domain.ContextAcesso.Entities
{
    public class Usuario
    {
        public Usuario(VNome nome, VEmail email, string senha, bool ativo, DateTime dataInclucaoRegistro, DateTime dataUltimoLogin)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            DataInclucaoRegistro = dataInclucaoRegistro;
            DataUltimoLogin = dataUltimoLogin;
        }


        #region Propriedades
        public VNome Nome { get; private set; }
        public VEmail Email { get; private set; }
        public string Senha { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime DataInclucaoRegistro { get; private set; }
        public DateTime DataUltimoLogin { get; private set; }
        #endregion

        //Metodos
        public void Registrar() { }


        //Eventos 
        public void AoRegistrar() {  /*dispara um email */}

       public override string ToString()
        {
            return $"" + Nome;
        }

    }
}