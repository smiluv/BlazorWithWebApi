using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<IEnumerable<Education>>> GetAllEducations()
        {
            return await myContext.Education.ToListAsync();
        }

        // GET api/<EducationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Education>> GetEducation(decimal id)
        {
            var myRecord = await myContext.Education.FindAsync(id);
            if (myRecord == null)
            {
                return NotFound();
            }

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
