using Fans.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fans.Controllers
{
	public class TeamController : Controller
	{
		private static UserdbContext _context;
		public TeamController(UserdbContext context) 
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var teams = await _context.Teams.ToListAsync();
			return View(teams);
		}
	}
}
