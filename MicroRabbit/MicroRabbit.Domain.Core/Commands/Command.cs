using MicroRabbit.Domain.Core.Events;
using System;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestmp { get; protected set; }

        protected Command()
        {
            this.Timestmp = DateTime.UtcNow;
        }
    }
}
