using PagamentosDominioComparti.ValueObjects;

namespace PagamentosDominio.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Endereco,"Email.Endereco","E-mail Inválido")
            );
            
        }

        public string Endereco { get; private set; }

    }
}