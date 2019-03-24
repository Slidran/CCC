using CCC.App.Interfaces;
using CCC.App.Models;
using CCC.Common.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CCC.App.Services
{
    public class CurrencyService : ICurrencyService
    {
        const string URL_CURRENCY_LIST_API = "https://localhost:44311/api/list";
        const string URL_CURRENCY_QUOTES_API = "https://localhost:44306/api/live";
        const string URL_CURRENCY_CONVERTER_API = "https://localhost:44307/api/converter";

        private CurrencyListModel CurrencyListModel { get; set; }

        public async Task<CurrencyDataModel> GetCurrencyLayerListData()
        {
            try
            {
                CurrencyDataModel result = new CurrencyDataModel();

                CurrencyListModel = await HttpHelper.GetAsync<CurrencyListModel>(URL_CURRENCY_LIST_API);
                result.CurrencyListModel = CurrencyListModel;

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CurrencyDataModel> GetCurrencyLayerData()
        {
            try
            {
                CurrencyDataModel result = new CurrencyDataModel();

                result.CurrencyListModel = CurrencyListModel ?? await HttpHelper.GetAsync<CurrencyListModel>(URL_CURRENCY_LIST_API);
                result.CurrencyQuotesModel = await HttpHelper.GetAsync<CurrencyQuotesModel>(URL_CURRENCY_QUOTES_API);
                
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Dictionary<string, decimal>> GetCalculatedCurrency(ConverterModel converterModel)
        {
            try
            {
                return await HttpHelper.GetAsync<Dictionary<string, decimal>>(URL_CURRENCY_CONVERTER_API, converterModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
