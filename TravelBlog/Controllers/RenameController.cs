using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rename.Models;

namespace Rename.Controllers
{
	public class RenameController : Controller
	{
		private RenameContext db = new RenameContext();
		public IActionResult Index()
		{
			//List<Item> model = db.Items.ToList();
			return View();
		}
	}
}