using Microsoft.AspNetCore.Mvc;
using MRBHub.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MRBHub.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TEIHubController : ControllerBase
    {
        private readonly IAdapterEngine _adapterEngine;
        public TEIHubController(IAdapterEngine adapterEngine)
        {
            _adapterEngine = adapterEngine ?? throw new ArgumentNullException(nameof(adapterEngine));
        }
        [HttpGet]
        [Route("GetWaltersModel/{url}")]
        public async Task<IActionResult> GetPowerUsage(string url)
        {
            var modelInfo = await _adapterEngine.WaltersParse(url);
            return Ok(modelInfo);
        }
    }
}
