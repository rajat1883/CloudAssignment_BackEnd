using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NAGPCloudAssignment.Model;

namespace NAGPCloudAssignment.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();
        
        // GET api/values
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            if(users.Count == 0)
            {
                users.Add(new User()
                {
                    FirstName = "Rajat",
                    LastName = "Arora",
                    EmailAddress = "rajat@gmail.com",
                    Address = "Delhi",
                    Age = 26,
                    PhoneNumber = "9847387474"
                });
            }
            return users;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {
            users.Add(user);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
