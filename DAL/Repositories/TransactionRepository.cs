using Common.Enums;
using Common.Interfaces;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MsisdnContext _context;

        public TransactionRepository(MsisdnContext context)
        {
            _context = context;
        }

        public int CountByType(DateTime fromDate, DateTime toDate, TransactionType transactionType)
        {
            return _context.Transactions.Count(x => x.TypeId == (int)transactionType && x.Created.Date >= fromDate && x.Created.Date < toDate);
        }

        public IEnumerable<Common.Models.Msisdn> TopMsisdnsByCallDuration(int top, DateTime fromDate, DateTime toDate)
        {
            return _context.Transactions
                .Include(x => x.Msisdn)
                .Where(x => x.TypeId == (int)TransactionType.Call && x.Created.Date >= fromDate && x.Created.Date < toDate)
                .OrderByDescending(x => x.Duration)
                .Take(top)
                .Select(x => new Common.Models.Msisdn
                {
                    Number = x.Msisdn.Number
                }).ToList();
        }

        public IEnumerable<Common.Models.Msisdn> TopMsisdnsBySms(int top, DateTime fromDate, DateTime toDate)
        {
            return _context.Transactions
                .Include(x => x.Msisdn)
                .Where(x => x.TypeId == (int)TransactionType.Sms && x.Created.Date >= fromDate && x.Created.Date < toDate)
                .OrderByDescending(x => x.Created)
                .Take(top)
                .Select(x => new Common.Models.Msisdn
                {
                    Number = x.Msisdn.Number
                }).ToList();
        }
    }
}
