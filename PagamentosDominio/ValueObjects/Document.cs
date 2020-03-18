using System;
using Flunt.Validations;
using PagamentosDominio.Enums;
using PagamentosDominioComparti.ValueObjects;

namespace PagamentosDominio.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type   = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(),"Document.Number", "Documento inválido")
            );
        }

        public string Number { get; private set; }

        public EDocumentType Type { get; private set; }

        private bool Validate(){
            if(Type==EDocumentType.CNPJ && Number.Length == 14)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}