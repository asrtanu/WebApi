﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        // GET: api/<UserDetailController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "arun", "singh","rawat" };
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
