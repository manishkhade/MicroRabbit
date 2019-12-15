using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
