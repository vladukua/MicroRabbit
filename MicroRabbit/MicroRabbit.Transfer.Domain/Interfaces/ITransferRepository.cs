using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IReadOnlyCollection<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
