using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        public MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = portfolioContext.Messages.ToList();
            return View(values);
        }
    }
}
