using System;

namespace PagamentosDominioComparti.Entidade
{
    public abstract class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id {get; private set;}
    }
}