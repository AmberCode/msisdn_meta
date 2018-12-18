using Common.Interfaces;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class TransactionServiceTests
    {
        [Fact]
        public void CountByType_Sms_Ok()
        {
            var fromDate = DateTime.Now.Date;
            var toDate = fromDate;

            var mock = new Mock<ITransactionRepository>();
            mock.Setup(x => x.CountByType(fromDate, toDate, Common.Enums.TransactionType.Sms))
                .Returns(3);

            var service = new TransactionService(mock.Object);
            var count = service.CountBySms(fromDate, toDate);
                                 
            Assert.True(count == 3);
        }

        [Fact]
        public void Top5ByCall_Ok()
        {
            var fromDate = DateTime.Now.Date;
            var toDate = fromDate;
            var mock = new Mock<ITransactionRepository>();
            mock.Setup(x => x.TopMsisdnsByCallDuration(5, fromDate, toDate))
                .Returns(new List<Common.Models.Msisdn>
                {
                    new Common.Models.Msisdn
                    {
                        Number = 37062300001
                    },
                    new Common.Models.Msisdn
                    {
                        Number = 37062300002
                    },
                    new Common.Models.Msisdn
                    {
                        Number = 37062300003
                    },
                    new Common.Models.Msisdn
                    {
                        Number = 37062300004
                    },
                    new Common.Models.Msisdn
                    {
                        Number = 37062300005
                    }
                });

            var service = new TransactionService(mock.Object);
            var list = service.Top5MsisdnsByCallDuration(fromDate, toDate);

            Assert.True(list.Count() == 5);
        }
    }
}
