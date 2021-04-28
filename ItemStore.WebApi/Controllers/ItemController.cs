using ItemStore.WebApi.Data;
using ItemStore.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ItemStore.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ItemController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dataContext.Items.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Item item)
        {
            item.Id = 0;

            _dataContext.Items.Add(item);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
