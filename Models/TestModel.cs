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
