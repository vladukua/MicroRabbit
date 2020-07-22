using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            this._context = context;
        }

        public IReadOnlyCollection<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs.ToList();
        }

        public void Add(TransferLog transferLog)
        {
            _context.TransferLogs.Add(transferLog);
            _context.SaveChanges();
        }
    }
}
