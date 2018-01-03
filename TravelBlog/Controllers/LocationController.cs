using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

namespace TravelBlog.Controllers
{
	public class LocationController : Controller
	{
		private TravelBlogContext db = new TravelBlogContext();

		public IActionResult Index()
        {
            return View(db.Locations.ToList());
		}

        public IActionResult Create() {
            ViewBag.id = new SelectList(db.Locations, "id", "name", "description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}