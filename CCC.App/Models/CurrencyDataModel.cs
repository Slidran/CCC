using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.App.Models
{
    public class CurrencyDataModel
    {
        public CurrencyListModel CurrencyListModel { get; set; }
        public CurrencyQuotesModel CurrencyQuotesModel { get; set; }
        public Dictionary<string, decimal> ConvertedValues { get; set; }
        public decimal Value { get; set; }
        public string From { get; set; }
    }
}
