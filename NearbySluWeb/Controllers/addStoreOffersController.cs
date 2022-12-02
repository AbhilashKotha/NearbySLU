using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NearbySluWeb.Models;
namespace NearbySluWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class storeOffersAddController : ControllerBase
    {
        private readonly storeOffersAddContext _context;

        public storeOffersAddController(storeOffersAddContext context)
        {
            _context = context;
        }

        // GET: api/addNewPlaces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<storeOffersAdd>>> GetOffersDetails()
        {
            return await _context.OffersDetails.ToListAsync();
        }

        // GET: api/addNewPlaces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<storeOffersAdd>> GetstoreOffersAdd(int id)
        {
            var storeOffersAdd = await _context.OffersDetails.FindAsync(id);

            if (storeOffersAdd == null)
            {
                return NotFound();
            }

            return storeOffersAdd;
        }

        // PUT: api/addNewPlaces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutstoreOffersAdd(int id, storeOffersAdd storeOffersAdd)
        {
            if (id != storeOffersAdd.offerId)
            {
                return BadRequest();
            }

            _context.Entry(storeOffersAdd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!storeOffersAddExists(id))
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

        // POST: api/addNewPlaces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<storeOffersAdd>> PoststoreOffersAdd(storeOffersAdd storeOffersAdd)
        {
            _context.OffersDetails.Add(storeOffersAdd);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetstoreOffersAdd", new { id = storeOffersAdd.offerId }, storeOffersAdd);
        }

        // DELETE: api/addNewPlaces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletestoreOffersAdd(int id)
        {
            var storeOffersAdd = await _context.OffersDetails.FindAsync(id);
            if (storeOffersAdd == null)
            {
                return NotFound();
            }

            _context.OffersDetails.Remove(storeOffersAdd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool storeOffersAddExists(int id)
        {
            return _context.OffersDetails.Any(e => e.offerId == id);
        }
    }
}
