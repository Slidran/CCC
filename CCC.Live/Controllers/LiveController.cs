using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCC.Live.Interfaces;
using CCC.Live.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCC.Live.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveController : ControllerBase
    {
        private readonly ILiveService _liveService;

        public LiveController(ILiveService liveService)
        {
            _liveService = liveService;
        }
        
        [HttpGet]
        public async Task<ActionResult<CurrencyQuotesModel>> Get()
        {
            return await _liveService.GetLiveCurrencies();
        }
    }
}
