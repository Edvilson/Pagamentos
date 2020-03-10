using System;

namespace PagamentosDominio.Entidades
{
     public class CartaoPagamento : Pagamento
    {
        public CartaoPagamento(string cartaoNome, 
                               string cartaoNumero, 
                               string numUltimaTransacao, 
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
            CartaoNome = cartaoNome;
            CartaoNumero = cartaoNumero;
            NumUltimaTransacao = numUltimaTransacao;
        }

        public string CartaoNome { get; private set; }
        public string CartaoNumero { get; private set; }
        public string NumUltimaTransacao { get; private set; }
    }

}