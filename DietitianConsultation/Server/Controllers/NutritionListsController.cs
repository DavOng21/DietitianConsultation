using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DietitianConsultation.Server.Data;
using DietitianConsultation.Shared.Domain;

namespace DietitianConsultation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionListsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NutritionListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NutritionLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NutritionList>>> GetNutritionLists()
        {
            return await _context.NutritionLists.ToListAsync();
        }

        // GET: api/NutritionLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NutritionList>> GetNutritionList(int id)
        {
            var nutritionList = await _context.NutritionLists.FindAsync(id);

            if (nutritionList == null)
            {
                return NotFound();
            }

            return nutritionList;
        }

        // PUT: api/NutritionLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNutritionList(int id, NutritionList nutritionList)
        {
            if (id != nutritionList.Id)
            {
                return BadRequest();
            }

            _context.Entry(nutritionList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NutritionListExists(id))
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

        // POST: api/NutritionLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NutritionList>> PostNutritionList(NutritionList nutritionList)
        {
            _context.NutritionLists.Add(nutritionList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNutritionList", new { id = nutritionList.Id }, nutritionList);
        }

        // DELETE: api/NutritionLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNutritionList(int id)
        {
            var nutritionList = await _context.NutritionLists.FindAsync(id);
            if (nutritionList == null)
            {
                return NotFound();
            }

            _context.NutritionLists.Remove(nutritionList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NutritionListExists(int id)
        {
            return _context.NutritionLists.Any(e => e.Id == id);
        }
    }
}
