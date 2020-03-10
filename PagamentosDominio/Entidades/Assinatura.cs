using System;
using System.Collections.Generic;

namespace PagamentosDominio.Entidades
{
    public class Assinatura
    {   
        private IList<Pagamento> _Pagamentos;
        public Assinatura(DateTime? dtExpiracao)
        {
            DtCriacao = DateTime.Now;
            DtUltimaAtualizao = DateTime.Now;
            DtExpiracao = dtExpiracao;
            Ativo = true;
            _Pagamentos = new List<Pagamento>();
        }

        public DateTime DtCriacao { get; private set; }
        public DateTime DtUltimaAtualizao { get; private set; }
        public DateTime? DtExpiracao { get; private set; }//? indica que a data é nulo
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get; set; }

        public void IncluirPagamento(Pagamento pagamento)
        {
            _Pagamentos.Add(pagamento);
        }

        public void Ativador()
        {
            Ativo = true;
            DtUltimaAtualizao = DateTime.Now;
        }

        public void Inativador()
        {
            Ativo = false;
            DtUltimaAtualizao = DateTime.Now;

        }
    }
}