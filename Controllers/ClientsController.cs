using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyClient.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _AppDbContext;

        public ClientsController(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        [HttpGet("/all")]
        public async Task<IActionResult> GetClients()
        {
            return Ok(new { success = true, data = await _AppDbContext.Clients.ToListAsync() });
        }
        [HttpGet("filter")]
        public async Task<IActionResult> GetClient(int id)
        {
            return Ok(new { success = true, data = await _AppDbContext.Clients.FindAsync(id) });
        }


        [HttpPost]
        public async Task<IActionResult> CreateCar(Client client)
        {
            _AppDbContext.Clients.Add(client);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = client });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClient(Client client)
        {
            _AppDbContext.Clients.Update(client);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = client });
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveClient(Client client)
        {
            _AppDbContext.Clients.Remove(client);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = client });
        }
    }
}
