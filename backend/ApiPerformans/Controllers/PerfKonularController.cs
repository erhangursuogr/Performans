using EntityLayer.Concrete;
using EntityLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPerformans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfKonularController : ControllerBase
    {
        private readonly OraContext _context;

        public PerfKonularController(OraContext context)
        {
            _context = context;
        }

        // GET: api/PerfKonular
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfKonular>>> GetPerfKonulars()
        {
            if (_context.PerfKonular == null)
            {
                return NotFound();
            }
            return await _context.PerfKonular.ToListAsync();
        }

        // GET: api/PerfKonular/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfKonular>> GetPerfKonular(decimal id)
        {
            if (_context.PerfKonular == null)
            {
                return NotFound();
            }
            var perfKonular = await _context.PerfKonular.FindAsync(id);

            if (perfKonular == null)
            {
                return NotFound();
            }

            return perfKonular;
        }

        // PUT: api/PerfKonular/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerfKonular(decimal id, PerfKonular perfKonular)
        {
            if (id != perfKonular.Id)
            {
                return BadRequest();
            }

            _context.Entry(perfKonular).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerfKonularExists(id))
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

        // POST: api/PerfKonular
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PerfKonular>> PostPerfKonular(PerfKonular perfKonular)
        {
            if (_context.PerfKonular == null)
            {
                return Problem("Entity set 'OraContext.PerfKonulars'  is null.");
            }
            _context.PerfKonular.Add(perfKonular);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PerfKonularExists(perfKonular.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPerfKonular", new { id = perfKonular.Id }, perfKonular);
        }

        // DELETE: api/PerfKonular/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerfKonular(decimal id)
        {
            if (_context.PerfKonular == null)
            {
                return NotFound();
            }
            var perfKonular = await _context.PerfKonular.FindAsync(id);
            if (perfKonular == null)
            {
                return NotFound();
            }

            _context.PerfKonular.Remove(perfKonular);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerfKonularExists(decimal id)
        {
            return (_context.PerfKonular?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}