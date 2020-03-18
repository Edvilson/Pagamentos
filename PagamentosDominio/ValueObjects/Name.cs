using Flunt.Validations;
using PagamentosDominioComparti.ValueObjects;
using System;

namespace PagamentosDominio.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3,"Name.PrimeiroNome", "Nome deve cotar pelo menos 3 caracteres")
                .HasMinLen(SegundoNome, 3,"Name.SegundoNome", "Segundo Nome deve cotar pelo menos 3 caracteres")
            );

        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
    }
}