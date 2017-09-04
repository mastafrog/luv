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
    /*
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class ProfileEntities : DbContext
    {
        public ProfileEntities() : base(nameOrConnectionString: "MyContext") { }
        public virtual DbSet<ProfileModel> Profiles { get; set; }
    }
    */

    /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {

    }*/

    // Enums

    /*
    public enum enum_genders
    {
		none = 0,
		male = 1,
		female = 2,
		transgender = 3,
		cisgender = 4
    }


    Simpler Version 
        none = 0,
        male = 1,
        female = 2,


    public enum req_relation 
    {
        all = 0, 
        friendship = 1,
        sex = 2, 
        longterm = 3
    }


// Basic ; 
    none = 0,
    alle = 5,
    male = 1,
    female = 2,


    public enum enum_req_gender {
        none = 0,
        alle = 5,
        male = 1,
        female = 2,
        transgender = 3,
        cisgender = 4
    }





	public enum req_age {
	//	0 = undefined
	    1 = all
	//	1, //18-24,
	//	2, //24-32,
	//	3, //32-40,
	//	4,//40-50,
	//	5, //50-60,
	//	6, //70... 
    }
   */


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
		public DateTime Birtday { get; set; }          
	
        [Column("password")]
        public string Password { get; set; }

       	[Column("gender")] 
        public int Gender { get; set; }

        [Column("descr")]
        public string Descr { get; set; }

        [Column("userpic")]
        public int Userpic { get; set; }

        [Column("images")]
        public int Images { get; set; }

        [Column("hobbies")]
        public string Hobbies { get; set; }

        [Column("signed")]
          public DateTime Signed { get; set; }

        [Column("active")]
         public int Active { get; set; }

        [Column("lastlogin")]
         public DateTime Lastlogin { get; set; }
          
        [Column("req_relation")]
        public int Req_relation { get; set; }

        [Column("req_gender")]
        public int Req_gender { get; set; }

        [Column("req_age")]
        public int Req_age { get; set; }

    }

}
