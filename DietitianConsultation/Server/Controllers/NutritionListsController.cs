using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DietitianConsultation.Server.Data;
using DietitianConsultation.Shared.Domain;
using DietitianConsultation.Server.IRepository;

namespace DietitianConsultation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionListsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public NutritionListsController(IUnitOfWork unitOfWork)
        {
            //refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/NutritionLists
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<NutritionList>>> GetNutritionLists()
        public async Task<IActionResult> GetNutritionLists()
        {
            // return await _context.NutritionLists.ToListAsync();
            //refacted
            var NutritionLists = await _unitOfWork.NutritionLists.GetAll(includes: q => q.Include(x => x.Food));
            return Ok(NutritionLists);
        }

        // GET: api/NutritionLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NutritionList>> GetNutritionList(int id)
        {
            // var nutritionlist = await _context.NutritionLists.FindAsync(id);
            var nutritionlist = await _unitOfWork.NutritionLists.Get(q => q.Id == id);

            if (nutritionlist == null)
            {
                return NotFound();
            }

            return nutritionlist;
        }

        // PUT: api/NutritionLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNutritionList(int id, NutritionList nutritionlist)
        {
            if (id != nutritionlist.Id)
            {
                return BadRequest();
            }

            //_context.Entry(nutritionlist).State = EntityState.Modified;
            _unitOfWork.NutritionLists.Update(nutritionlist);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != nutritionlist.Id)
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
        public async Task<ActionResult<NutritionList>> PostNutritionList(NutritionList nutritionlist)
        {
            //_context.NutritionLists.Add(nutritionlist);
            //await _context.SaveChangesAsync();
            await _unitOfWork.NutritionLists.Insert(nutritionlist);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetNutritionList", new { id = nutritionlist.Id }, nutritionlist);
        }

        // DELETE: api/NutritionLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNutritionList(int id)
        {
            //var nutritionlist = await _context.NutritionLists.FindAsync(id);
            var nutritionlist = await _unitOfWork.NutritionLists.Get(q => q.Id == id);
            if (nutritionlist == null)
            {
                return NotFound();
            }

            // _context.NutritionLists.Remove(nutritionlist);
            // await _context.SaveChangesAsync();
            await _unitOfWork.NutritionLists.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> NutritionListExists(int id)
        {
            // return _context.NutritionLists.Any(e => e.Id == id);
            var nutritionlist = await _unitOfWork.NutritionLists.Get(q => q.Id == id);
            return nutritionlist != null;
        }
    }
}
