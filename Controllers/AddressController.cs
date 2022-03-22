using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAddress.Models;
using MyClient.Models;
using System.Threading.Tasks;

namespace MyAddress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AppDbContext _AppDbContext;

        public AddressController(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAdress()
        {
            return Ok(new { success = true, data = await _AppDbContext.Clients.ToListAsync() });
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(Address address)
        {
            _AppDbContext.Address.Add(address);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = address });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(Address address)
        {
            _AppDbContext.Address.Update(address);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = address });
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddress(Address address)
        {
            _AppDbContext.Address.Remove(address);
            await _AppDbContext.SaveChangesAsync();
            return Ok(new { success = true, data = address });
        }
    }
}
