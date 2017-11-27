using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyAPI.Controllers
{
    public class UserController : ApiController
    {
        Pharmacy db = new Pharmacy();
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public class user
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }
        // GET api/<controller>/5
        public IQueryable<User> Get(user newuser)
        {
            return db.Users.Where(p => p.login == newuser.Login).Where(p => p.password == newuser.Password);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {

        }

        // PUT api/<controller>/5
        //public IQueryable Put(string login,string password, [FromBody]User value)
        //{
            
        //}

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}