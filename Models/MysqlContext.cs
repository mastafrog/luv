﻿using System.Data.Entity;

namespace Luv.Models
{

	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public partial class MysqlContext : DbContext
	{
		public MysqlContext() : base(nameOrConnectionString: "MyContext") { }
		public virtual DbSet<TestModel> Tests { get; set; }
        public virtual DbSet<ProfileModel> Profiles { get; set; }

    }
    
}
