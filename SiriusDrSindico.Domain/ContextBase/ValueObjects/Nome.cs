// using FluentValidator;
// using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextBase.ValueObjects
{
    public class Nome 
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            // AddNotifications(new ValidationContract()
            //     .Requires()
            //     .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
            //     .HasMaxLen(FirstName, 40, "FirstName", "O nome deve conter no máximo 40 caracteres")
            //     .HasMinLen(LastName, 3, "LastName", "O sobrenome deve conter pelo menos 3 caracteres")
            //     .HasMaxLen(LastName, 40, "LastName", "O sobrenome deve conter no máximo 40 caracteres")
            // );
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }
    }
}
