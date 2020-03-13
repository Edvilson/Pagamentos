using System;
using Flunt.Notifications;

namespace PagamentosDominioComparti.Entidade
{
    public abstract class Entidade : Notifiable
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id {get; private set;}
    }
}