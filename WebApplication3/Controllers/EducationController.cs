using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        TrainingContext myContext = new TrainingContext();
        // GET: api/<EducationController>
        [HttpGet]
        public IEnumerable<Education> Get()
        {
            return myContext.Education.ToList();
        }

        // GET api/<EducationController>/5
        [HttpGet("{id}")]
        public Education Get(int id)
        {
            var myRecord = myContext.Education.Where(e => e.Id == id).FirstOrDefault();
            return myRecord;
        }

        // POST api/<EducationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EducationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EducationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
