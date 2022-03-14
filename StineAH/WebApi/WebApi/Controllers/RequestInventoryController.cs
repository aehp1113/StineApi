using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RequestInventoryController : ControllerBase
    {
        private readonly IRequestInventoryService _requestInventoryService;
        public RequestInventoryController(IRequestInventoryService requestInventoryService)
        {
            _requestInventoryService = requestInventoryService;
        }
        
        [HttpGet("getRequestInventory")]
        public async Task<IActionResult> GetRequestInventory()
        {

            return Ok(await _requestInventoryService.GetRequestInventory());
        }
    }
}
