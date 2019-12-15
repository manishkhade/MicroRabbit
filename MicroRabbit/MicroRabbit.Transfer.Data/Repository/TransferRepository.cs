using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext transferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            this.transferDbContext = transferDbContext;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferDbContext.TransferLogs;
        }
    }
}
