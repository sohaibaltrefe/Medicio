using AutoMapper;
using Medicio.DAL.Models;
using Medicio.DLL.Data;
using Medicio.PL.Areas.Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Medicio.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]

    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ServicesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var services = context.Services.ToList();
            var servicesvm = mapper.Map<IEnumerable<ServicesVM>>(services);

            return View(servicesvm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceFormVM VM)
        {
            if (!ModelState.IsValid)
            {
                return View(VM);

            }
            var service = mapper.Map<Service>(VM);
            context.Add(service);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var service = context.Services.Find(id);
            if (service is null)
            {
                return NotFound();
            }
            var servicemodel = mapper.Map<serviceDetailsVM>(service);
            return View(servicemodel);
        }
        [HttpGet]

        public IActionResult Delete(int id)
        {
            var service = context.Services.Find(id);
            if (service is null)
            {
                return NotFound();
            }
            var serviceVM = mapper.Map<ServicesVM>(service);
            return View(serviceVM);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            var service = context.Services.Find(id);
            if (service is null)
            {
                return RedirectToAction(nameof(Index));
            }
            context.Services.Remove(service);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
