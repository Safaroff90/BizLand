using BizLand.DAL;
using BizLand.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BizLandDbContext = BizLand.DAL.BizLandDbContext;

namespace BizLand.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BizLandDbContext _context;
        public ServiceController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View(_context.Services.ToList());
        }


        public IActionResult Detail(int id)
        {
            Service service = _context.Services.ToList().Find(x => x.Id == id);

            return View(service);
        }
       


        
    }
}
