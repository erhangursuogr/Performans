using ApiPerformans.Models.ViewModels;
using ApiPerformans.Repositories;
using EntityLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace ApiPerformans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonemController : ControllerBase
    {
        private readonly OraContext _context;
        private readonly IDonemService _donemService;

        public DonemController(OraContext context, IDonemService donemService)
        {
            _context = context;
            _donemService = donemService;
        }

        // GET: api/Donem
        [HttpGet]
        public async Task<IActionResult> GetDonemler()
        {
            var response = await _donemService.GetDonemler();
            return response.StatusCode switch
            {
                404 => NotFound(response),
                500 => StatusCode(500, response),
                _ => Ok(response)
            };
        }

        // GET: api/Donem/5
        [HttpGet("{yil}")]
        public async Task<IActionResult> GetPerfDonem(int yil)
        {
            var response = await _donemService.GetDonem(yil);
            return response.StatusCode switch
            {
                404 => NotFound(response),
                400 => BadRequest(response),
                500 => StatusCode(500, response),
                _ => Ok(response)
            };
        }

        // POST: api/Donem
        [HttpPost]
        public async Task<IActionResult> AddDonem(DonemViewModel donem)
        {
            var response = await _donemService.AddDonem(donem);
            return response.StatusCode switch
            {
                404 => NotFound(response),
                400 => BadRequest(response),
                500 => StatusCode(500, response),
                _ => Ok(response)
            };
        }

        // PUT: api/Donem/5
        [HttpPut("{yil}")]
        public async Task<IActionResult> UpdateDonem(int yil, DonemViewModel donem)
        {
            var response = await _donemService.UpdateDonem(yil, donem);
            return response.StatusCode switch
            {
                404 => NotFound(response),
                400 => BadRequest(response),
                500 => StatusCode(500, response),
                _ => Ok(response)
            };
        }

        // DELETE: api/Donem/5
        [HttpDelete("{yil}")]
        public async Task<IActionResult> DeleteDonem(int yil)
        {
            var response = await _donemService.DeleteDonem(yil);
            return response.StatusCode switch
            {
                404 => NotFound(response),
                400 => BadRequest(response),
                500 => StatusCode(500, response),
                _ => Ok(response)
            };
        }

        private bool PerfDonemExists(int yil)
        {
            return (_context.PerfDonem?.Any(e => e.Yil == yil)).GetValueOrDefault();
        }
    }
}