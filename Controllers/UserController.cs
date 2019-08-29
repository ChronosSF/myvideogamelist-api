using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using myvideogamelist.Models;
using Google.Apis.Auth.OAuth2;

using System.Security.Claims;

namespace myvideogamelist.Controllers
{
	[Authorize]
	[ApiController]
	public class UsersController : ControllerBase
	{
		
		[AllowAnonymous]
		[EnableCors]
		[HttpPost]
		[Route("ExternalLogin", Name = "ExternalLogin")]
		public async IActionResult GetExternalLogin(ExternalUser externalUser)
		{

			ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);
			Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
			Authentication.SignIn(identity);

			return Ok(new JWT);


			//if (error != null)
			//{
			//	return Redirect(Url.Content("~/") + "#error=" + System.Uri.EscapeDataString(error));
			//}

			//if (!User.Identity.IsAuthenticated)
			//{
			//	return new ChallengeResult(provider, this);
			//}

			//ExternalLoginData externalLogin = ExternalUser.FromIdentity(User.Identity as ClaimsIdentity);

			//if (externalLogin == null)
			//{
			//	return InternalServerError();
			//}

			//if (externalLogin.LoginProvider != provider)
			//{
			//	Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
			//	return new ChallengeResult(provider, this);
			//}

			//string steamId = SteamServiceProvider.SteamUserId(externalLogin.ProviderKey);

			//ApplicationUser user = await UserManager.FindByIdAsync(steamId);

			//bool hasRegistered = user != null;
			//string returnUrl = "";

			//if (!hasRegistered)
			//{
			//	if (externalLogin.LoginProvider == "Steam")
			//	{
			//		IdentityResult x = await this.Register(externalLogin);
			//		if (!x.Succeeded)
			//		{
			//			return InternalServerError();
			//		}
			//		user = await UserManager.FindByIdAsync(steamId);
			//		// Upon registration, redirect to the user's profile for information setup.
			//		returnUrl = "players/" + steamId + "/true";
			//	}
			//}
			//IEnumerable<Claim> claims = externalLogin.GetClaims();
			//ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);
			//Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
			//Authentication.SignIn(identity);

			//return Redirect(CORSConfig.allowedOrigins + '/' + returnUrl); //Ok();

		}

		///private IUserService _userService;

		//public UsersController(IUserService userService)
		//{
		//	_userService = userService;
		//}

		//[AllowAnonymous]
		//[HttpPost("authenticate")]
		//public IActionResult Authenticate([FromBody]User userParam)
		//{
		//	var user = _userService.Authenticate(userParam.UserName, userParam.Password);

		//	Google.Apis.Auth.Task<GoogleJsonWebSignature.Payload> ValidateAsync(string jwt, GoogleJsonWebSignature.ValidationSettings validationSettings)

		//	if (user == null)
		//		return BadRequest(new { message = "Username or password is incorrect" });

		//	return Ok(user);
		//}

		//[HttpGet]
		//public IActionResult GetAll()
		//{
		//	var users = _userService.GetAll();
		//	return Ok(users);
		//}
	}
}
