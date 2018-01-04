using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;
using TravelBlog.ViewModels;

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
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

		public IActionResult Edit(int id)
		{
			var thisItem = db.Locations.FirstOrDefault(location => location.id == id);
			
			return View(thisItem);
		}
		[HttpPost]
		public IActionResult Edit(Location location)
		{
			db.Entry(location).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
            var thisItem = db.Locations.FirstOrDefault(location => location.id == id);
			return View(thisItem);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			var thisItem = db.Locations.FirstOrDefault(location => location.id == id);
			db.Locations.Remove(thisItem);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult AddExperience(int id)
		{
            var model = new LocationExperiencesModel(id);
			return View(model);
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			db.Experiences.Add(experience);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}