using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCC.Converter.Interfaces;
using CCC.Converter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCC.Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConverterController : ControllerBase
    {
        private readonly IConvertService _convertService;

        public ConverterController(IConvertService convertService)
        {
            _convertService = convertService;
        }

        [HttpGet]
        public ActionResult<Dictionary<string, decimal>> Get(ConverterModel converterModel)
        {
            return _convertService.Converter(converterModel);
        }
    }
}
