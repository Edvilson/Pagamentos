using System;
using System.Collections.Generic;

namespace PagamentosDominio.Entidades
{
    public abstract class Pagamento // abstrato pois não pode ser instanciado a qualquer momento
    {
        protected Pagamento(DateTime data, DateTime dtExpiracao, decimal total, decimal totalPagamento, string documento, string pagador, string endereco, string email)
        {
            Data = data;
            DtExpiracao = dtExpiracao;
            Total = total;
            TotalPagamento = totalPagamento;
            Documento = documento;
            Pagador = pagador;
            Sequencia = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            Endereco = endereco;
            Email = email;
        }

        public DateTime Data { get; private set; }
        public DateTime DtExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPagamento { get; private set; }
        public string Documento { get; private set; }
        public string Pagador { get; private set; }
        public string Sequencia { get; private set; }
        public string Endereco { get; private set; }        
        public string Email { get; private set; }
    }


}