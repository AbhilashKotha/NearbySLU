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
    public class addNewPlacesController : ControllerBase
    {
        private readonly addNewPlaceContext _context;

        public addNewPlacesController(addNewPlaceContext context)
        {
            _context = context;
        }

        // GET: api/addNewPlaces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<addNewPlace>>> GetPlaceDetails()
        {
            return await _context.PlaceDetails.ToListAsync();
        }

        // GET: api/addNewPlaces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<addNewPlace>> GetaddNewPlace(int id)
        {
            var addNewPlace = await _context.PlaceDetails.FindAsync(id);

            if (addNewPlace == null)
            {
                return NotFound();
            }

            return addNewPlace;
        }

        // PUT: api/addNewPlaces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutaddNewPlace(int id, addNewPlace addNewPlace)
        {
            if (id != addNewPlace.placeId)
            {
                return BadRequest();
            }

            _context.Entry(addNewPlace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!addNewPlaceExists(id))
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
        public async Task<ActionResult<addNewPlace>> PostaddNewPlace(addNewPlace addNewPlace)
        {
            _context.PlaceDetails.Add(addNewPlace);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetaddNewPlace", new { id = addNewPlace.placeId }, addNewPlace);
        }

        // DELETE: api/addNewPlaces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteaddNewPlace(int id)
        {
            var addNewPlace = await _context.PlaceDetails.FindAsync(id);
            if (addNewPlace == null)
            {
                return NotFound();
            }

            _context.PlaceDetails.Remove(addNewPlace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool addNewPlaceExists(int id)
        {
            return _context.PlaceDetails.Any(e => e.placeId == id);
        }
    }
}
