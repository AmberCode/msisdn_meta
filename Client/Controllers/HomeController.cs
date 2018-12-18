using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Common.Models;
using Common.Services;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransactionService _transactionService;

        public HomeController([FromServices] ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Filter(FilterRequest request)
        {
            try
            {
                DateTime fromDate;

                if (!DateTime.TryParse(request.FromDate, out fromDate))
                {
                    return new JsonResult("Invalid input")
                    {
                        StatusCode = 400
                    };
                }

                DateTime toDate;

                if (!DateTime.TryParse(request.ToDate, out toDate))
                {
                    return new JsonResult("Invalid input")
                    {
                        StatusCode = 400
                    };
                }

                var countBySms = _transactionService.CountBySms(fromDate, toDate);
                var countByCall = _transactionService.CountByCall(fromDate, toDate);
                var top5ByCall = _transactionService.Top5MsisdnsByCallDuration(fromDate, toDate);
                var top5BySms = _transactionService.Top5MsisdnsBySms(fromDate, toDate);

                return Json(
                    new { 
                        countBySms,
                        countByCall,
                        top5ByCall,
                        top5BySms
                    }
                );
            }
            catch(Exception)
            {
                //log ex
                return new JsonResult("System error")
                {
                    StatusCode = 500
                };
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
