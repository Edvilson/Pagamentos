using System;
using PagamentosDominio.ValueObjects;

namespace PagamentosDominio.Entidades
{
   
     public class BoletoPagamento : Pagamento
    {
        public BoletoPagamento(string codBarra, 
                               string numBoleto,
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
            CodBarra = codBarra;
            NumBoleto = numBoleto;
        }

        public string CodBarra { get; private set; }
        public string NumBoleto { get; private set; }
    }

}