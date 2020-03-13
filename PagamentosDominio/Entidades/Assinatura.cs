using System;
using System.Collections.Generic;
using Flunt.Validations;
using PagamentosDominioComparti.Entidade;

namespace PagamentosDominio.Entidades
{
    public class Assinatura : Entidade
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
            
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, pagamento.DtExpiracao, "Assinatura.Pagamentos", "A data do pagamento não pode ser atrasada"));
            
            _Pagamentos.Add(pagamento);

            //Validar se o pagamento esta valido antes de comitar a informação no BD;
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