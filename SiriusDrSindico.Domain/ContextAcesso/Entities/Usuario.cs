using System;
using SiriusDrSindico.Domain.ContextBase.ValueObjects;

namespace SiriusDrSindico.Domain.ContextAcesso.Entities
{
    public class Usuario
    {
        public Usuario(Nome nome, Email email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Ativo = true;
        }

        #region Propriedades
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime DataInclucaoRegistro { get; private set; }
        public DateTime DataUltimoLogin { get; private set; }
        #endregion

        //Metodos
        public void Registrar() { }


        //Eventos 
        public void AoRegistrar() {  /*dispara um email */}


    }
}