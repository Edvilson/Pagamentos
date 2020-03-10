using System;
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
            CodBarra = codBarra;
            NumBoleto = numBoleto;
        }

        public string CodBarra { get; private set; }
        public string NumBoleto { get; private set; }
    }

}