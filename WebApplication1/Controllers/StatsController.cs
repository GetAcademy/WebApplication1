using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            var model = new StatsViewModel();
            model.Start = DateTime.Today.Subtract(TimeSpan.FromDays(7));
            model.End = DateTime.Today;
            GetData(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(StatsViewModel model)
        {
            GetData(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult NewDate(StatsViewModel model, int deltaStart, int deltaEnd)
        {
            model.Start = model.Start.AddDays(deltaStart);
            model.End = model.End.AddDays(deltaEnd);
            GetData(model);
            return View("Index", model);
        }

        private static void GetData(StatsViewModel model)
        {
            model.Data = Measurement.GetDummyData()
                .Where(m => m.Date >= model.Start && m.Date <= model.End)
                .ToList();
        }

    }
}