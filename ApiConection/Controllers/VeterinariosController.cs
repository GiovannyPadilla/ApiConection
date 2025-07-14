using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiConection.Data;
using ApiConection.Models;

namespace ApiConection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeterinariosController : ControllerBase
    {
        private readonly VitalPetsDbContext _context;

        public VeterinariosController(VitalPetsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinarios>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veterinarios>> GetVeterinario(int id)
        {
            var vet = await _context.Veterinarios.FindAsync(id);
            if (vet == null)
                return NotFound();
            return vet;
        }

        [HttpPost]
        public async Task<ActionResult<Veterinarios>> PostVeterinario(Veterinarios vet)
        {
            _context.Veterinarios.Add(vet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVeterinario), new { id = vet.Id }, vet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVeterinario(int id, Veterinarios vet)
        {
            if (id != vet.Id)
                return BadRequest();

            _context.Entry(vet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeterinario(int id)
        {
            var vet = await _context.Veterinarios.FindAsync(id);
            if (vet == null)
                return NotFound();

            _context.Veterinarios.Remove(vet);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
