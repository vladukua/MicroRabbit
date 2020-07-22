using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this._transferRepository = transferRepository;
            this._bus = bus;
        }

        public IReadOnlyCollection<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
