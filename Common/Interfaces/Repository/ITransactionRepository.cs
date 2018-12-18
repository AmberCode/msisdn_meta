using Common.Enums;
using Common.Models;
using System;
using System.Collections.Generic;


namespace Common.Interfaces
{
    public interface ITransactionRepository
    {
        int CountByType(DateTime fromDate, DateTime toDate, TransactionType transactionType);
        IEnumerable<Msisdn> TopMsisdnsBySms(int top, DateTime fromDate, DateTime toDate);
        IEnumerable<Msisdn> TopMsisdnsByCallDuration(int top, DateTime fromDate, DateTime toDate);
    }
}
