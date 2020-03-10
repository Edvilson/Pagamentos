using System;

namespace PagamentosDominio.Entidades
{
     public class PaypalPagamento : Pagamento
    {
        public PaypalPagamento(string codigoTransacao, 
                               DateTime data, 
                               DateTime dtExpiracao, 
                               decimal total, 
                               decimal totalPagamento, 
                               string documento, 
                               string pagador, 
                               string endereco, 
                               string email):base(
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