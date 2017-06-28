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
    public partial class ProfileEntities : DbContext
    {
        public ProfileEntities() : base(nameOrConnectionString: "MyContext") { }
        public virtual DbSet<ProfileModel> Profiles { get; set; }
    }

	/*protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {

    }*/

	// Enums

    public enum enum_gender
    {
		none,
		male,
		female,
		transgender,
		cisgender
    }

    public enum req_relation 
    {
        all, 
        friendship, 
        sex, 
        longterm
    }

    public enum enum_req_gender {
        all,
        male,
        female,
        transgender,
        cisgender
    }
   

	public enum req_age {
	/*	all,
		1, //18-24,
		2, //24-32,
		3, //32-40,
		4,//40-50,
		5,//50-60,
		6,//70-**/
    }




    [Table("luv_users")]
    public class ProfileModel
    {
        [Key]
        [Column("uid")]
        public int Id { get; set; }

        [Column("username")]
        public string Name { get; set; }

		[Column("mail")]
		public string Mail { get; set; }

		[Column("birthday")]
		public DateTime Birtday { get; set; }           // = DateTime.Now;  
	
        [Column("password")]
        public string Password { get; set; }

		[Column("gender")] 
        public enum_gender Gender { get; set; }

		[Column("descr")]
        public int Descr { get; set; }

		[Column("userpic")]
        public int Userpic { get; set; }

		[Column("images")]
        public int Images { get; set; }

		[Column("hobbies")]
        public int Hobbies { get; set; }

		[Column("signed")]
        public int Signed { get; set; }

		[Column("active")]
        public int Active { get; set; }

		[Column("lastlogin")]
        public int Lastlogin { get; set; }

		[Column("req_relation")]
        public req_relation Req_relation { get; set; }

		[Column("req_gender")]
        public enum_req_gender Req_gender { get; set; }

		[Column("req_age")]
        public int Req_age { get; set; }

	}
}
