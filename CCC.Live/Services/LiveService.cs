using CCC.Common.Utils;
using CCC.Live.Interfaces;
using CCC.Live.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CCC.Live.Services
{
    public class LiveService : ILiveService
    {
        const string URL_LIVE = "http://www.apilayer.net/api/live?access_key=03eb2486fe632221d017f14534c70055";

        public async Task<CurrencyQuotesModel> GetLiveCurrencies()
        {
            return await HttpHelper.GetAsync<CurrencyQuotesModel>(URL_LIVE);
        }
    }
}
