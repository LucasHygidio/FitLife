using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitLife.Data;
using FitLife.Models;

namespace FitLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietLogsController : ControllerBase
    {
        private readonly DataContext _context;

        public DietLogsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DietLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DietLog>>> GetDietLogTable()
        {   
            var dietLog = await _context.DietLogTable.ToListAsync();

            return Ok(dietLog);
        }

        // GET: api/DietLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DietLog>> GetDietLogById(int id)
        {
            var dietLog = await _context.DietLogTable.FindAsync(id);

            if (dietLog == null) // se ele nao encontrar nada no dietlog retorna notfound
            {
                return NotFound();
            }

            return Ok(dietLog); 
        }

        // PUT: api/DietLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDietLog(int id, [FromBody] DietLog dietLog)
        {
            if (dietLog == null)
            {
                return BadRequest("Corpo da requisição inválido");
            }
            var existing = _context.DietLogTable.FirstOrDefault(x => x.LogId == id);
            if (existing == null)
                return NotFound(new { Message = $"Dieta com Id={id} não encontrada." });


            _context.Entry(existing).CurrentValues.SetValues(dietLog);
            _context.SaveChanges();

            return Ok(new
            {
                Message = "Refeição atualizada com sucesso.",
                Updated = dietLog
            });
        }

        // POST: api/DietLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DietLog>> PostDietLog([FromBody]DietLog dietLog)
        {
            if (dietLog == null)
                return BadRequest("O corpo da requisição é inválido.");

            if (_context.DietLogTable.Any(x => x.LogId == dietLog.LogId)){
                return Conflict(new { Message = $"Já existe uma refeição com Id={dietLog.LogId}." });
            }

            _context.DietLogTable.Add(dietLog);
            _context.SaveChanges(); 

            return CreatedAtAction(nameof(GetDietLogTable), new { id = dietLog.LogId }, dietLog);
        }

        // DELETE: api/DietLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDietLog(int id)
        {
            var dietLog = _context.DietLogTable.FirstOrDefault(x => x.LogId == id);
            if (dietLog == null)
                return NotFound(new { Message = $"Refeição com Id={id} não encontrada." });

            _context.DietLogTable.Remove(dietLog);
            _context.SaveChanges();
            return Ok(new { Message = $"Refeição '{dietLog.MealName}' removida com sucesso." });
        }

        private bool DietLogExists(int id)
        {
            return _context.DietLogTable.Any(e => e.LogId == id);
        }
    }
}
