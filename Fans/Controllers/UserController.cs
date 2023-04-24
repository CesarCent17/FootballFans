using Fans.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fans.Controllers
{
	public class UserController : Controller
	{
        private static UserdbContext _context;


		public UserController(UserdbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var users = await _context.Users.ToListAsync();
			return View(users);
		}
	}
}
