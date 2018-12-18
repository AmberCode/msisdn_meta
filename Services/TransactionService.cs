using Common.Enums;
using Common.Interfaces;
using Common.Models;
using Common.Services;
using System;
using System.Collections.Generic;

namespace Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public int CountBySms(DateTime fromDate, DateTime toDate)
        {
            return _transactionRepository.CountByType(fromDate, toDate, TransactionType.Sms);
        }

        public int CountByCall(DateTime fromDate, DateTime toDate)
        {
            return _transactionRepository.CountByType(fromDate, toDate, TransactionType.Call);
        }
        
        public IEnumerable<Msisdn> Top5MsisdnsByCallDuration(DateTime fromDate, DateTime toDate)
        {
            return _transactionRepository.TopMsisdnsByCallDuration(5, fromDate, toDate);
        }

        public IEnumerable<Msisdn> Top5MsisdnsBySms(DateTime fromDate, DateTime toDate)
        {
            return _transactionRepository.TopMsisdnsBySms(5, fromDate, toDate);
        }
    }
}
