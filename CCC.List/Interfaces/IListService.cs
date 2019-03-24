using CCC.List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.List.Interfaces
{
    public interface IListService
    {
        Task<CurrencyListModel> GetCurrenciesList();
    }
}
