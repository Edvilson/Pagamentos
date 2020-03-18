using System;
using PagamentosDominio.Enums;

namespace PagamentosDominio.Comandos
{
    public class CreateBoletoAssinatura
    {
        public string PrimeiroNome { get;  set; }
        public string SegundoNome { get;  set; }
        public string endereco { get;  set; }
        public string Numero { get;  set; }
        public string CodBarra { get;  set; }
        public string NumBoleto { get;  set; }

        public DateTime Data { get;  set; }
        public DateTime DtExpiracao { get;  set; }
        public decimal Total { get;  set; }
        public decimal TotalPagamento { get;  set; }
        public EDocumentType Documento { get;  set; }
        public string Pagador { get;  set; }
        public string Sequencia { get;  set; }
        public string Endereco { get;  set; }        
        public string Email { get;  set; }
        public string endereco { get; private set; }
        public string Numero { get; private set; }
        public string Vizinhanca { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
        public string CodigoPostal { get; private set; }
    }
    
}