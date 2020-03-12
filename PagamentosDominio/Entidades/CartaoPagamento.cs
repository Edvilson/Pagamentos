using System;
using PagamentosDominio.ValueObjects;

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
            CartaoNome = cartaoNome;
            CartaoNumero = cartaoNumero;
            NumUltimaTransacao = numUltimaTransacao;
        }

        public string CartaoNome { get; private set; }
        public string CartaoNumero { get; private set; }
        public string NumUltimaTransacao { get; private set; }
    }

}