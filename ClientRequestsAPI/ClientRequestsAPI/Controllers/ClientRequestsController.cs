using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientRequestsAPI.Data;
using ClientRequestsAPI.Models;
using System;

namespace ClientRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientRequestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientRequestsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("submit-client-data")]
        public async Task<IActionResult> SubmitClientData([FromBody] ClientRequest request)
        {
            if (request == null)
                return BadRequest(new { message = "Datos inválidos" });

            _context.ClientRequests.Add(request);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Datos almacenados con éxito" });
        }
    }
}
