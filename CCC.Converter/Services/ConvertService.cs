using CCC.Converter.Interfaces;
using CCC.Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.Converter.Services
{
    public class ConvertService : IConvertService
    {
        public Dictionary<string, decimal> Converter(ConverterModel converterModel)
        {
            var from = Convert.ToDecimal(converterModel.Quotes.Where(x => x.Key.Substring(3) == converterModel.From).FirstOrDefault().Value);

            var convertedValues = CurrencyConverter(from, converterModel.Value, converterModel.Currencies, converterModel.Quotes);

            return convertedValues;
        }

        private Dictionary<string, decimal> CurrencyConverter(decimal originCurrencyQuote, decimal value, Dictionary<string, string> currencies, Dictionary<string, double> quotes)
        {
            var result = new Dictionary<string, decimal>();

            if (originCurrencyQuote > 0)
            {
                foreach (var item in currencies)
                {
                    var to = Convert.ToDecimal(quotes.Where(x => x.Key.Substring(3) == item.Key).FirstOrDefault().Value);
                    result.Add($"{item.Key} - {item.Value}", Math.Round((to / originCurrencyQuote) * value, 2));
                }
            }

            return result;
        }
    }
}
