using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Luv.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public partial class TestContext : DbContext
	{
		public TestContext() : base(nameOrConnectionString: "MyContext") { }
		public virtual DbSet<TestClass> Tests { get; set; }
	}



	/*protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{

	}*/

	[Table("test")]
    public class TestClass
    {
		[Key]
		[Column("id")]
		public int Id { get; set; }
		[Column("name")]
		public string Name { get; set; }
    }
}
