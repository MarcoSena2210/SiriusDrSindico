// using FluentValidator;
// using FluentValidator.Validation;

namespace SiriusDrSindico.Domain.ContextBase.ValueObjects
{
    public class Email //: Notifiable
    {
        public Email(string endereco)
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
