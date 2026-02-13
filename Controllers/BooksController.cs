namespace BiblioApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly AppDbContext _context;
    
    public BooksController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/books
    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
        => await _context.Books.ToListAsync();

    // GET: api/books/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> Get(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
            return NotFound();
        return book;
    }



    // POST: api/books
    [HttpPost]
    public async Task<ActionResult<Book>> Post(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
    }
}

/*
using Microsoft.AspNetCore.Mvc;

namespace BiblioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<string> books = new()
        {
            "Clean Code",
            "The Pragmatic Programmer"
        };

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] string book)
        {
            books.Add(book);
            return Ok(books);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            if (id < 0 || id >= books.Count)
                return NotFound();

            books.RemoveAt(id);
            return Ok(books);
        }
    }
}
*/