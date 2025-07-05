using System;

namespace CEU.Core.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; protected set; }

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}