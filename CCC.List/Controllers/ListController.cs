using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCC.List.Interfaces;
using CCC.List.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCC.List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IListService _liveService;

        public ListController(IListService liveService)
        {
            _liveService = liveService;
        }

        [HttpGet]
        public async Task<ActionResult<CurrencyListModel>> Get()
        {
            return await _liveService.GetCurrenciesList();
        }
    }
}
