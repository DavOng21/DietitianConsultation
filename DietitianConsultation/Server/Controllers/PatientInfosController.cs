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
    public class PatientInfosController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PatientInfosController(IUnitOfWork unitOfWork)
        {
            //refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/PatientInfos
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<PatientInfo>>> GetPatientInfos()
        public async Task<IActionResult> GetPatientInfos()
        {
            // return await _context.PatientInfos.ToListAsync();
            //refacted
            var PatientInfos = await _unitOfWork.PatientInfos.GetAll(includes: q => q.Include(x => x.Patient));
            return Ok(PatientInfos);
        }

        // GET: api/PatientInfos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientInfo>> GetPatientInfo(int id)
        {
            // var patientinfo = await _context.PatientInfos.FindAsync(id);
            var patientinfo = await _unitOfWork.PatientInfos.Get(q => q.Id == id);

            if (patientinfo == null)
            {
                return NotFound();
            }

            return patientinfo;
        }

        // PUT: api/PatientInfos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientInfo(int id, PatientInfo patientinfo)
        {
            if (id != patientinfo.Id)
            {
                return BadRequest();
            }

            //_context.Entry(patientinfo).State = EntityState.Modified;
            _unitOfWork.PatientInfos.Update(patientinfo);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != patientinfo.Id)
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

        // POST: api/PatientInfos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PatientInfo>> PostPatientInfo(PatientInfo patientinfo)
        {
            //_context.PatientInfos.Add(patientinfo);
            //await _context.SaveChangesAsync();
            await _unitOfWork.PatientInfos.Insert(patientinfo);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPatientInfo", new { id = patientinfo.Id }, patientinfo);
        }

        // DELETE: api/PatientInfos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientInfo(int id)
        {
            //var patientinfo = await _context.PatientInfos.FindAsync(id);
            var patientinfo = await _unitOfWork.PatientInfos.Get(q => q.Id == id);
            if (patientinfo == null)
            {
                return NotFound();
            }

            // _context.PatientInfos.Remove(patientinfo);
            // await _context.SaveChangesAsync();
            await _unitOfWork.PatientInfos.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PatientInfoExists(int id)
        {
            // return _context.PatientInfos.Any(e => e.Id == id);
            var patientinfo = await _unitOfWork.PatientInfos.Get(q => q.Id == id);
            return patientinfo != null;
        }
    }
}
