using System.Collections.Generic;
using System.Linq;
using PagamentosDominio.ValueObjects;
using PagamentosDominioComparti.Entidade;

namespace PagamentosDominio.Entidades
{
    public class Estudante : Entidade
    {
        private IList<Assinatura> _Assinaturas;
        public Estudante(Name name, Document documento, Email email, string endereco)
        {
            Name = name;
            Documento = documento;
            Email = email;
            _Assinaturas = new List<Assinatura>();
        }

        public Name Name { get; private set; }
        public Document Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinatura { get{ return _Assinaturas.ToArray();} }

        public void IncluirAssinatura(Assinatura assinatura)
        {
            //Se já haver assinatura ativa, cancela
            foreach (var sub in Assinatura)
            {
                sub.Inativador();
            }

            _Assinaturas.Add(assinatura);
        }
        
    }
}