using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvgl.Models;
using Mvgl.Services;
using System.Collections.Generic;

namespace Mvgl.Controllers
{
	//[Authorize]
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		[AllowAnonymous]
		[HttpPost("authenticate")]
		public IActionResult Authenticate([FromBody]AuthenticateModel model)
		{
			var user = _userService.Authenticate(model.Username, model.Password);

			if (user == null)
				return BadRequest(new { message = "Username or password is incorrect" });

			return Ok(user);
		}

		[HttpGet]
		public ActionResult<IEnumerable<User>> GetUsers()
		{
			//var todoItem = await _context.TodoItems.FindAsync(id);

			var users = _userService.GetAll();
			if (users == null)
			{
				return NotFound();
			}

			return Ok(users);
		}
	}
}
