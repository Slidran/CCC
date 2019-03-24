using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CCC.App.Models;
using System.Net.Http;
using Newtonsoft.Json;
using CCC.App.Interfaces;

namespace CCC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public HomeController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currencyLayerData = await _currencyService.GetCurrencyLayerData();
            return View(currencyLayerData);
        }

        [HttpGet]
        public async Task<IActionResult> Calculated(string from, string value)
        {
            var currencyLayerData = await _currencyService.GetCurrencyLayerData();
            ConverterModel converterModel = new ConverterModel
            {
                From = from,
                Value = Convert.ToDecimal(value),
                Currencies = currencyLayerData.CurrencyListModel.Currencies,
                Quotes = currencyLayerData.CurrencyQuotesModel.Quotes
            };

            var calculatedValues = await _currencyService.GetCalculatedCurrency(converterModel);
            
            currencyLayerData.ConvertedValues = calculatedValues;
            currencyLayerData.Value = Convert.ToDecimal(value);
            currencyLayerData.From = from;

            return View(currencyLayerData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
