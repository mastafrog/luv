using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Luv.Models;
using Newtonsoft.Json;
using System.Web.Http.Tracing;

namespace Luv.Controllers
{
    public class ProfilesController : ApiController
    {

        public class Profile
        {
          //  public int      Id { get; set; }
          //  public string   Name { get; set; }
          //  public string   Category { get; set; }
          //  public decimal  Price { get; set; }
        }

        public static MysqlContext Context = new MysqlContext();


     /*   public ProfilesController() 
        {

		}
	 */




        [Route("api/profiles")]
        [HttpPost]
        public IHttpActionResult GetProfiles()
        {
            // IEnumerable
            var profiles = new ProfileModel();
            var blup = Context.Profiles.ToList();//SingleOrDefault();//.Find();
        /*    var json = Newtonsoft.Json.JsonConvert.SerializeObject( 
                           blup, 
                           Formatting.Indented, 
                           new JsonSerializerSettings { 
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore 
                        });
                        */

            
            var json = JsonConvert.SerializeObject(blup);
            return Ok( json );
        }


        // Get Profiles with Pagination
        [Route("api/profiles/{skipNr}")]
        [HttpPost]
        public IHttpActionResult GetProfiles(int skipNr)
        {
            // IEnumerable
            var profiles = new ProfileModel();
            var blup = Context.Tests.ToList();//SingleOrDefault();//.Find();
                                              /*  return Newtonsoft.Json.JsonConvert.SerializeObject( 
                                                         blup, 
                                                         Formatting.Indented, 
                                                         new JsonSerializerSettings { 
                                                         ReferenceLoopHandling = ReferenceLoopHandling.Ignore 
                                                      });*/

           // var json = JsonConvert.SerializeObject(blup);
            return Ok("You have send "+ skipNr);
        }


        // GET Profile
        [Route("api/profile")]
        [HttpGet]
        public IHttpActionResult GetProfile(int profileId)
        {
            var profile = Context.Tests.SingleOrDefault(TestModel => TestModel.Id == profileId);
            if (profile == null)
            {
                return NotFound();
            }
            // return Ok(JsonConvert.SerializeObject(profile));
            return Ok("look at this face! its a" + profileId);
        }




        /// <summary>
        /// Hier genauer 
        /// https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
        /// </summary>
        /// <returns>The profile.</returns>


        // PUT Profile
        [Route("api/profile")]
        [HttpPut]
        public IHttpActionResult InsertProfile()
        {
            Random r = new Random();

            var profile = new ProfileModel();
            profile.Name = "Name";
            profile.Mail = "Mailmail@yahoo.de";
            profile.Birtday = DateTime.Now.AddDays(-365.25);
            profile.Password = profile.Name;                    //TODO Aouth2 Implementieren at least direct
            profile.Gender = 18;                             // TODO Ab jetzt nach unten
            profile.Descr = "Trulala";
            profile.Userpic = 12;
            profile.Images = 4;
            profile.Hobbies = "essen, schleißen";

            profile.Signed = DateTime.Now.AddDays(-(r.Next(10, 356 * 4)));    // 4 Yahre                  //DateTime.Now.AddDays( -(r * 665.25)); }
            profile.Active = 1;

            profile.Lastlogin = DateTime.Now.AddDays(-(r.Next(1, 40)));

            profile.Req_relation = r.Next(0, 4);
            profile.Req_gender = r.Next(0, 4);
            profile.Req_age = r.Next(1, 4);


            Context.Profiles.Add(profile);  //AddOrUpdate
            Context.SaveChanges();
            /*
            Context.Tests.SingleOrDefault(T estModel => TestModel.Id == profileId);
            if (profile == null)
            {
                return NotFound();
            }
            */

            // return Ok(JsonConvert.SerializeObject(profile));
            //      return Ok("look at this face! its a" + profileId);

            return Ok(JsonConvert.SerializeObject(profile));


        }


        // POST api/person
        public IHttpActionResult /*HttpResponseMessage*/ Post([FromBody]Profile value)
        {
        /*  Profile fck = new Profile();
            fck.Name = "xfkjfhdskjf";
            fck.Id = 12;
        */
            return Ok(JsonConvert.SerializeObject(value));


            //    Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject( fck ) );
            /*
            var profiles.Add(new Profile() { Id = 9, Name = "Blabla" });
            HttpResponseMessage response = Request.CreateResponse("Blabla message" + profiles.ToString());
            return response;
            */
            //    new Profile { Id = 1, Name = "Tomato Soup" };
        }


        // PUT api/person/5
        public HttpResponseMessage Put(/*int id,*/ [FromBody]Profile value) 
        {
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(value));
        }

    /*
    ---> hier gehts weiter
    https://stackoverflow.com/questions/31022668/how-to-receive-json-data-on-webapi-backend-c

    https://tools.ietf.org/html/rfc7231#section-4.3

    Debug.WriteLine(data.Type);
    Debug.WriteLine(data.Id);


    */

		/*[HttpPost]
		public bool AddOrder([FromBody] PurchaseOrder order)
		{
            
		}*/
        

		// DELETE api/person/5
		// TODO return something like esponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError
		/*public void Delete(int id)
        {
            var itemToRemove = Context.Tests.SingleOrDefault(x => x.Id == id); //returns a single item.
         //   var response = new HttpStatusCode();

            if (itemToRemove != null) {
                Context.Tests.Remove(itemToRemove);
                Context.SaveChanges();
            } else {
				
			}
		}*/


    }
}


/*
 * INSERT INTO `luv_users` (`uid`, `username`, `mail`, `birthday`, `password`, `gender`, `descr`, `userpic`, `images`, `hobbies`, `signed`, `active`, `lastlogin`, `req_relation`, `req_gender`, `req_age`) VALUES (NULL, 'Chubaka', 'Chubaka@gmail.com', '1982-06-06', 'qwertz', 'cisgender', 'Lorem blup ', '2', '1,2,3,4', 'qw,qwe,er,sdf,dg,wer', '2017-06-22', '1', '2017-06-22', 'all', 'all', 'all');
*/
/*
 * 
https://github.com/alisabzevari/LiteApi * 
https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api
http://www.tablesgenerator.com/markdown_tables
http://www.thinkprogramming.co.uk/code-first-with-mysql-and-entity-framework-6/
https://www.ntchosting.com/encyclopedia/databases/mysql/insert-date/
https://andrewlock.net/adding-ef-core-to-a-project-on-os-x/
http://www.entityframeworktutorial.net/EntityFramework4.3/dbcontext-vs-objectcontext.aspx
*/

/*
 * anonyme type context response
 * https://stackoverflow.com/questions/657939/serialize-entity-framework-objects-into-json
*/