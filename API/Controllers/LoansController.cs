using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] //localhost:5001/api/loans
    [ApiController]
    public class LoansController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<LoanModel>>> GetMembers()
        {
            var loans = await context.Loans.ToListAsync();
            return Ok(loans);
        }
             [HttpGet("{id}")] //localhost:5001/api/loans/id
        public async Task<ActionResult<LoanModel>> GetMember(string id)
        {
            var loan = await context.Loans.FindAsync(id);
            if (loan == null) return NotFound();
            return Ok(loan);
        }
    }
}
