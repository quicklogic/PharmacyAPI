using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyAPI.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/<controller>
        Pharmacy db = new Pharmacy();
        public class user
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }
        // GET api/<controller>/5
        public IQueryable<User> Get(user newuser)
        {
            var result = db.Users.Where(p => p.login == newuser.Login).Where(p => p.password == newuser.Password);

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]user newuser)
        {
            db.Users.Where(p => p.login == newuser.Login).Where(p => p.password == newuser.Password);
            return Ok(User);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}