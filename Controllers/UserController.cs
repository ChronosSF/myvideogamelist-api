using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Mvgl.Models;

namespace Mvgl.Controllers
{
	[Authorize]
	[ApiController]
	public class UsersController : ControllerBase
	{

		////[OverrideAuthentication]
		//[HostAuthentication(DefaultAuthenticationTypes.ExternalCookie)]
		//[AllowAnonymous]
		//[Route("ExternalLogin", Name = "ExternalLogin")]
		//public async Task<IHttpActionResult> GetExternalLogin(string provider, string error = null, string returnUrl = "")
		//{
		//	Uri returnUri = new Uri(returnUrl.Length > 0 ? returnUrl : CORSConfig.returnOrigin);
		//	string returnHost = returnUri.GetLeftPart(UriPartial.Authority);
		//	string returnPath = returnUri.AbsolutePath;

		//	if (error != null)
		//	{
		//		return Redirect(returnHost + "/unauthorized");
		//	}

		//	if (!User.Identity.IsAuthenticated)
		//	{
		//		return new ChallengeResult(provider, this);
		//	}

		//	ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(User.Identity as ClaimsIdentity);

		//	if (externalLogin == null)
		//	{
		//		return Redirect(returnHost + "/unauthorized");
		//	}

		//	if (externalLogin.LoginProvider != provider)
		//	{
		//		Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
		//		if (provider == "Steam")
		//		{
		//			return new ChallengeResult(provider, this);
		//		}
		//		else
		//		{
		//			return new ChallengeResult(provider, this, Url.Link("ActionApi", new { controller = "Account", action = "AddExternalLogin", userId = GetAuthUser().Id }));
		//		}
		//	}

		//	ApplicationUser user = GetAuthUser();

		//	bool hasRegistered = user != null;

		//	if (!hasRegistered)
		//	{
		//		if (externalLogin.LoginProvider == "Steam")
		//		{
		//			IdentityResult x = await Register(externalLogin);
		//			if (!x.Succeeded)
		//			{
		//				return Redirect(returnHost + "/unauthorized");
		//			}
		//			user = GetAuthUser();
		//			// Upon registration, redirect to the user's profile for information setup.
		//			returnPath = "/players/" + user.Id + "/true";
		//		}
		//		else
		//		{
		//			return Redirect(returnHost + "/addsteam");
		//		}
		//	}
		//	IEnumerable<Claim> claims = externalLogin.GetClaims();
		//	ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);
		//	Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
		//	Authentication.SignIn(identity);

		//	return Redirect(returnHost + returnPath);

		//}
		//// GET api/Account/ExternalLogins?returnUrl=%2F&generateState=true
		//[AllowAnonymous]
		//[Route("ExternalLogins")]
		//public IEnumerable<ExternalLoginViewModel> GetExternalLogins(string returnUrl, bool generateState = false)
		//{
		//	IEnumerable<AuthenticationDescription> descriptions = Authentication.GetExternalAuthenticationTypes();
		//	List<ExternalLoginViewModel> logins = new List<ExternalLoginViewModel>();

		//	string state;

		//	if (generateState)
		//	{
		//		const int strengthInBits = 256;
		//		state = RandomOAuthStateGenerator.Generate(strengthInBits);
		//	}
		//	else
		//	{
		//		state = null;
		//	}

		//	foreach (AuthenticationDescription description in descriptions)
		//	{
		//		ExternalLoginViewModel login = new ExternalLoginViewModel
		//		{
		//			Name = description.Caption,
		//			Url = Url.Route("ExternalLogin", new
		//			{
		//				provider = description.AuthenticationType,
		//				response_type = "token",
		//				client_id = Startup.PublicClientId,
		//				redirect_uri = new Uri(Request.RequestUri, returnUrl).AbsoluteUri,
		//				state
		//			}),
		//			State = state
		//		};
		//		logins.Add(login);
		//	}

		//	return logins;
		//}

		/////private IUserService _userService;
		/////


		//[Route("Logout")]
		//public IHttpActionResult Logout()
		//{
		//	Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
		//	Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
		//	return Ok();
		//}

	}
}
