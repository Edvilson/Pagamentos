using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PagamentosDominio.ValueObjects;
using PagamentosDominioComparti.Entidade;

namespace PagamentosDominio.Entidades
{
    public class Estudante : Entidade
    {
        private IList<Assinatura> _Assinaturas;
        public Estudante(Name name, Document documento, Email email)
        {
            Name = name;
            Documento = documento;
            Email = email;
            _Assinaturas = new List<Assinatura>();           
            
            AddNotifications(name, documento, email);
        }

        public Name Name { get; private set; }
        public Document Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinatura { get{ return _Assinaturas.ToArray();} }

        public void IncluirAssinatura(Assinatura assinatura)
        {
           var hasSubscripitonActive = false;
           foreach (var sub in _Assinaturas)
           {
               if (sub.Ativo)
               {
                   hasSubscripitonActive = true;
               }
           }
            
            //Pode ser feita validação dessa forma
            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscripitonActive,"Esudante.Assinatura", "Você já possui uma assinatura ativa")
            );

            //Ou dessa forma
            if (hasSubscripitonActive)
            {
                AddNotification("Estudante.Assinatura","Você já tem uma assinatura ativa");
            }

        }
        
    }
}