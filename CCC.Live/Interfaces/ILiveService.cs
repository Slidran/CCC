using CCC.Live.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.Live.Interfaces
{
    public interface ILiveService
    {
        Task<CurrencyQuotesModel> GetLiveCurrencies();
    }
}
