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
    public class PatientsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PatientsController(IUnitOfWork unitOfWork)
        {
            //refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Patients
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        public async Task<IActionResult> GetPatients()
        {
            // return await _context.Patients.ToListAsync();
            //refacted
            var Patients = await _unitOfWork.Patients.GetAll();
            return Ok(Patients);
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            // var patient = await _context.Patients.FindAsync(id);
            var patient = await _unitOfWork.Patients.Get(q => q.Id == id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(int id, Patient patient)
        {
            if (id != patient.Id)
            {
                return BadRequest();
            }

            //_context.Entry(patient).State = EntityState.Modified;
            _unitOfWork.Patients.Update(patient);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != patient.Id)
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

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient patient)
        {
            //_context.Patients.Add(patient);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Patients.Insert(patient);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPatient", new { id = patient.Id }, patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            //var patient = await _context.Patients.FindAsync(id);
            var patient = await _unitOfWork.Patients.Get(q => q.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            // _context.Patients.Remove(patient);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Patients.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PatientExists(int id)
        {
            // return _context.Patients.Any(e => e.Id == id);
            var patient = await _unitOfWork.Patients.Get(q => q.Id == id);
            return patient != null;
        }
    }
}
