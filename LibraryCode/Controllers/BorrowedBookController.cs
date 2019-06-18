using LibraryCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        private readonly LibraryContext _context;

        [HttpGet]
        [ProducesResponseType(typeof(BorrowedBookModels), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BorrowedBookModels>>> GetAllBorrowedBooks()
        {
            return await _context.BorrowedBooks.ToListAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BorrowedBookModels), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BorrowedBookModels>> GetBorrowedBook(long id)
        {
            var borrowedBook = await _context.BorrowedBooks.FindAsync(id);

            if (borrowedBook == null)
            {
                return NotFound();
            }

            return borrowedBook;
        }

        [HttpPost]
        [ProducesResponseType(typeof(BorrowedBookModels), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BorrowedBookModels>> PostBorrowedBook([FromBody] BorrowedBookModels borrowedBook)
        {
            _context.BorrowedBooks.Add(borrowedBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBorrowedBook), new { id = borrowedBook.Id }, borrowedBook);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBorrowedBook(long id, BorrowedBookModels borrowedBook)
        {
            if (id != borrowedBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(borrowedBook).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBorrowedBook(long id)
        {
            var borrowedBook = await _context.BorrowedBooks.FindAsync(id);

            if (borrowedBook == null)
            {
                return NotFound();
            }

            _context.BorrowedBooks.Remove(borrowedBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
