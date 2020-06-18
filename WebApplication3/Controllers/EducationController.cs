using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private TrainingContext _context = new TrainingContext();

        // GET: api/<EducationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Education>>> GetAllEducations()
        {
            return await _context.Education.ToListAsync();
        }

        // GET api/Education/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Education>> GetEducation(decimal id)
        {
            var myRecord = await _context.Education.FindAsync(id);
            if (myRecord == null)
            {
                return NotFound();
            }

            return myRecord;
        }

        // POST: api/Education
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Education>> PostEducation(Education education)
        {
            _context.Education.Add(education);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllEducations", new { id = education.Id }, education);
        }

        // PUT api/<EducationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDetails>> PutEducation(decimal id, Education education)
        {
            if (id != education.Id)
            {
                return BadRequest();
            }

            _context.Entry(education).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (EducationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool EducationExists(decimal id)
        {
            return _context.Education.Any(e => e.Id == id);
        }

        // DELETE api/<EducationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Education>> DeleteEducation(decimal id)
        {
            var educationDetail = await _context.Education.FindAsync(id);
            if (educationDetail == null)
            {
                return NotFound();
            }

            _context.Education.Remove(educationDetail);
            await _context.SaveChangesAsync();

            return educationDetail;
        }
    }
}