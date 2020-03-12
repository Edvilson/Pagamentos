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
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
    }
}