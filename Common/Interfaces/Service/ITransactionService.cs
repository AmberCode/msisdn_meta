using Common.Enums;
using Common.Models;
using System;
using System.Collections.Generic;

namespace Common.Services
{
    public interface ITransactionService
    {
        int CountBySms(DateTime fromDate, DateTime toDate);
        int CountByCall(DateTime fromDate, DateTime toDate);
        IEnumerable<Msisdn> Top5MsisdnsBySms(DateTime fromDate, DateTime toDate);
        IEnumerable<Msisdn> Top5MsisdnsByCallDuration(DateTime fromDate, DateTime toDate);
    }
}
