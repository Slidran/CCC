using CCC.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.App.Interfaces
{
    public interface ICurrencyService
    {
        Task<CurrencyDataModel> GetCurrencyLayerData();
        Task<CurrencyDataModel> GetCurrencyLayerListData(); 
        Task<Dictionary<string, decimal>> GetCalculatedCurrency(ConverterModel converterModel);
    }
}
