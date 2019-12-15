using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    class TransferService : ITransferService
    {
        private readonly IEventBus _bus;
        private readonly ITransferRepository transferRepository;

        public TransferService(IEventBus bus, ITransferRepository transferRepository)
        {
            _bus = bus;
            this.transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return this.transferRepository.GetTransferLogs();
        }
    }
}
