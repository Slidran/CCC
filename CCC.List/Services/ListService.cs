using CCC.Common.Utils;
using CCC.List.Interfaces;
using CCC.List.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CCC.List.Services
{
    public class ListService : IListService
    {
        const string URL_LIST = "http://www.apilayer.net/api/list?access_key=03eb2486fe632221d017f14534c70055";

        public async Task<CurrencyListModel> GetCurrenciesList()
        {
            return await HttpHelper.GetAsync<CurrencyListModel>(URL_LIST);
        }
    }
}
