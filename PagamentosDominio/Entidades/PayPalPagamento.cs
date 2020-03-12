using System;
using PagamentosDominio.ValueObjects;

namespace PagamentosDominio.Entidades
{
     public class PaypalPagamento : Pagamento
    {
        public PaypalPagamento(string codigoTransacao, 
                               DateTime data, 
                               DateTime dtExpiracao, 
                               decimal total, 
                               decimal totalPagamento, 
                               Document documento, 
                               string pagador, 
                               Endereco endereco, 
                               Email email):base(
                                   data, 
                                   dtExpiracao, 
                                   total, 
                                   totalPagamento, 
                                   documento, 
                                   pagador, 
                                   endereco, 
                                   email)
        {
            CodigoTransacao = codigoTransacao;
        }

        public string CodigoTransacao { get; private set; }
    }
}