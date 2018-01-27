using Aplakhtiy.TestForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplakhtiy.TestForm.DAL
{
	public class UsersContext : DbContext
	{
		public UsersContext() : base("UsersDb")
		{
			Database.SetInitializer<UsersContext>(new CreateDatabaseIfNotExists<UsersContext>());
		}

		public DbSet<User> Users { get; set; }

	}
}