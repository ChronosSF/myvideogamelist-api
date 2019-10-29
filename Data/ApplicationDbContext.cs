using Mvgl.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvgl.Data
{
	public class ApplicationDbContext : DbContext
	{
		DbSet<User> Users { get; set; }

		public ApplicationDbContext(
			DbContextOptions options) : base(options)
		{
		}
	}
}
