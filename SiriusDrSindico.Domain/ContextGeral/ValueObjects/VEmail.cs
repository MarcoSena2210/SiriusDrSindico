// using FluentValidator;
// using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextGeral.ValueObjects
{
    public class VEmail //: Notifiable
    {
        public VEmail(string endereco)
        {
            Endereco = endereco;

            // AddNotifications(new ValidationContract()
            //     .Requires()
            //     .IsEmail(Address, "Email", "O E-mail é inválido")
            // );
        }

        public string Endereco { get; private set; }

        public override string ToString()
        {
            return Endereco;
        }
    }
}
