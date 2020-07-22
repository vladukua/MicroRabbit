using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IReadOnlyCollection<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
