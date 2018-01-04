using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;
using System.Diagnostics;
using System.IO;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class ExperienceController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();

        public IActionResult Index(int id)
        {
            var theList = db.Experiences.Where(e => e.locationId == id);
            return View(theList.ToList());
        }

		public IActionResult Edit(int id)
		{
			var thisItem = db.Experiences.FirstOrDefault(location => location.id == id);

			return View(thisItem);
		}
		[HttpPost]
        public IActionResult Edit(Experience experience)
		{
            int locationId = experience.locationId;
			db.Entry(experience).State = EntityState.Modified;
			db.SaveChanges();
            return RedirectToAction("Index", new { id = locationId });
		}

		public ActionResult Delete(int id)
		{
            var thisItem = db.Experiences.FirstOrDefault(experience => experience.id == id);
			return View(thisItem);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
            var thisItem = db.Experiences.FirstOrDefault(experience => experience.id == id);
            int locationId = thisItem.locationId;
			db.Experiences.Remove(thisItem);
			db.SaveChanges();
            return RedirectToAction("Index", new { id = locationId});
		}

	}
}
