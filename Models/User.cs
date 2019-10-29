using System;
using System.ComponentModel.DataAnnotations;

namespace Mvgl.Models
{
	public class User
	{
		[Key]
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Avatar { get; set; }
		public string Password { get; set; }
		public string Token { get; set; }
	}
}
