using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.DBModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        private apnastoreContext _context;

        public UserDetailController(apnastoreContext context)
        {
            this._context = context;
        }

        // GET: api/<UserDetailController>
        [HttpGet]
        public Task<List<UserDetail>> Get()
        {
            return Task.Run(() => _context.UserDetail.ToList());
                      //return new string[] { "arun", "singh","rawat" };
        }

        // GET api/<UserDetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserDetailController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
