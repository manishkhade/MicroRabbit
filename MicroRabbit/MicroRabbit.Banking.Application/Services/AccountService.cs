using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            this._accountRepository = accountRepository;
            this.eventBus = eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return this._accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTranfer)
        {
            var transferCommand = new CreateTransferCommand(
                accountTranfer.FromAccount, 
                accountTranfer.ToAccount, 
                accountTranfer.TransferAmount);

            eventBus.SendCommand(transferCommand);
        }
    }
}
