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
    public class CategoryListController : ControllerBase
    {
        private readonly CategoryListContext _context;

        public CategoryListController(CategoryListContext context)
        {
            _context = context;
        }

        // GET: api/CategoryList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryList>>> GetCategoryList()
        {
            return await _context.CategoryList.ToListAsync();
        }

        // GET: api/CategoryList/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryList>> GetCategoryList(int id)
        {
            var categoryList = await _context.CategoryList.FindAsync(id);

            if (categoryList == null)
            {
                return NotFound();
            }

            return categoryList;
        }

        // PUT: api/CategoryList/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoryList(int id, CategoryList categoryList)
        {
            if (id != categoryList.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(categoryList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryListExists(id))
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

        // POST: api/CategoryList
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoryList>> PostCategoryList(CategoryList categoryList)
        {
            _context.CategoryList.Add(categoryList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoryList", new { id = categoryList.CategoryId }, categoryList);
        }

        // DELETE: api/CategoryList/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryList(int id)
        {
            var categoryList = await _context.CategoryList.FindAsync(id);
            if (categoryList == null)
            {
                return NotFound();
            }

            _context.CategoryList.Remove(categoryList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryListExists(int id)
        {
            return _context.CategoryList.Any(e => e.CategoryId == id);
        }
    }
}
