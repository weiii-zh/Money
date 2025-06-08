using Microsoft.AspNetCore.Mvc;
using Money.Data;
using Money.Models;
using System.Linq;

namespace Money.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var transactions = _context.Transactions.ToList();
            return View(transactions);
        }

        [HttpPost]
        public IActionResult Add(string name, decimal amount)
        {
            var t = new Transaction
            {
                ProductName = name,
                Amount = amount,
                ConfirmedByA = false,
                ConfirmedByB = false
            };
            _context.Transactions.Add(t);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Confirm(int id, string who)
        {
            var t = _context.Transactions.Find(id);
            if (t != null)
            {
                if (who == "A") t.ConfirmedByA = true;
                if (who == "B") t.ConfirmedByB = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
