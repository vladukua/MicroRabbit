using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IReadOnlyCollection<TransferLog> GetTransferLogs();
    }
}
