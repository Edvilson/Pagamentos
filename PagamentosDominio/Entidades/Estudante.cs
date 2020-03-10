using System.Collections.Generic;
using System.Linq;

namespace PagamentosDominio.Entidades
{
    public class Estudante
    {
        private IList<Assinatura> _Assinaturas;
        public Estudante(string primeiroNome, string segundoNome, string documento, string email, string endereco)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;
            Documento = documento;
            Email = email;
            _Assinaturas = new List<Assinatura>();
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
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