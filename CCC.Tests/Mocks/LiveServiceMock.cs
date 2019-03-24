﻿using CCC.Live.Interfaces;
using CCC.Live.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CCC.Tests.Mocks
{
    public class LiveServiceMock : ILiveService
    {
        public async Task<CurrencyQuotesModel> GetLiveCurrencies()
        {
            var currencyQuotesModel = new CurrencyQuotesModel()
            {
                Success = true,
                Terms = new Uri("https://currencylayer.com/terms"),
                Privacy = new Uri("https://currencylayer.com/privacy"),
                Timestamp = 1553438824,
                Source = "USD",
                Quotes = new Dictionary<string, double>()
                {
                    { "USDAED", 3.673042 },
                    { "USDAFN", 75.730404 },
                    { "USDALL", 109.960403 },
                    { "USDAMD", 484.270403 },
                    { "USDANG", 1.83145 },
                    { "USDAOA", 317.256504 },
                    { "USDARS", 40.931041 },
                    { "USDAUD", 1.411041 },
                    { "USDAWG", 1.801 },
                    { "USDAZN", 1.705041 },
                    { "USDBAM", 1.72765 },
                    { "USDBBD", 1.9931 },
                    { "USDBDT", 83.754041 },
                    { "USDBGN", 1.729804 },
                    { "USDBHD", 0.376305 },
                    { "USDBIF", 1802.65 },
                    { "USDBMD", 1.0 },
                    { "USDBND", 1.349041 },
                    { "USDBOB", 6.89185 },
                    { "USDBRL", 3.905504 },
                    { "USDBSD", 0.99811 },
                    { "USDBTC", 0.00025 },
                    { "USDBTN", 69.182606 },
                    { "USDBWP", 10.680504 },
                    { "USDBYN", 2.10795 },
                    { "USDBYR", 19600.0 },
                    { "USDBZD", 2.01115 },
                    { "USDCAD", 1.344655 },
                    { "USDCDF", 1634.000362 },
                    { "USDCHF", 0.992775 },
                    { "USDCLF", 0.025048 },
                    { "USDCLP", 671.825041 },
                    { "USDCNY", 6.718204 },
                    { "USDCOP", 3083.05 },
                    { "USDCRC", 598.505041 },
                    { "USDCUC", 1.0 },
                    { "USDCUP", 26.5 },
                    { "USDCVE", 97.40704 },
                    { "USDCZK", 22.78804 },
                    { "USDDJF", 177.720394 },
                    { "USDDKK", 6.603604 },
                    { "USDDOP", 50.657504 },
                    { "USDDZD", 119.030393 },
                    { "USDEGP", 17.221504 },
                    { "USDERN", 15.000358 },
                    { "USDETB", 28.49404 },
                    { "USDEUR", 0.883355 },
                    { "USDFJD", 2.127704 },
                    { "USDFKP", 0.760045 },
                    { "USDGBP", 0.75663 },
                    { "USDGEL", 2.680391 },
                    { "USDGGP", 0.756856 },
                    { "USDGHS", 5.089604 },
                    { "USDGIP", 0.760045 },
                    { "USDGMD", 49.703853 },
                    { "USDGNF", 9104.503851 },
                    { "USDGTQ", 7.665304 },
                    { "USDGYD", 208.28504 },
                    { "USDHKD", 7.847404 },
                    { "USDHNL", 24.395504 },
                    { "USDHRK", 6.574204 },
                    { "USDHTG", 83.75504 },
                    { "USDHUF", 280.290388 },
                    { "USDIDR", 14307.5 },
                    { "USDILS", 3.621704 },
                    { "USDIMP", 0.756856 },
                    { "USDINR", 69.170504 },
                    { "USDIQD", 1190.9 },
                    { "USDIRR", 42105.000352 },
                    { "USDISK", 119.550386 },
                    { "USDJEP", 0.756856 },
                    { "USDJMD", 124.890386 },
                    { "USDJOD", 0.70904 },
                    { "USDJPY", 109.92504 },
                    { "USDKES", 100.59504 },
                    { "USDKGS", 69.741904 },
                    { "USDKHR", 4014.503799 },
                    { "USDKMF", 435.875039 },
                    { "USDKPW", 900.082329 },
                    { "USDKRW", 1136.103792 },
                    { "USDKWD", 0.30341 },
                    { "USDKYD", 0.831765 },
                    { "USDKZT", 377.660383 },
                    { "USDLAK", 8571.650383 },
                    { "USDLBP", 1506.550382 },
                    { "USDLKR", 177.710382 },
                    { "USDLRD", 162.503775 },
                    { "USDLSL", 14.380382 },
                    { "USDLTL", 2.95274 },
                    { "USDLVL", 0.60489 },
                    { "USDLYD", 1.379104 },
                    { "USDMAD", 9.616204 },
                    { "USDMDL", 17.234039 },
                    { "USDMGA", 3547.203758 },
                    { "USDMKD", 54.091504 },
                    { "USDMMK", 1519.65038 },
                    { "USDMNT", 2616.5 },
                    { "USDMOP", 8.06705 },
                    { "USDMRO", 357.000346 },
                    { "USDMUR", 34.530379 },
                    { "USDMVR", 15.503741 },
                    { "USDMWK", 729.085039 },
                    { "USDMXN", 19.093039 },
                    { "USDMYR", 4.064504 },
                    { "USDMZN", 63.375039 },
                    { "USDNAD", 14.380377 },
                    { "USDNGN", 359.000344 },
                    { "USDNIO", 32.817504 },
                    { "USDNOK", 8.556039 },
                    { "USDNPR", 109.995039 },
                    { "USDNZD", 1.454039 },
                    { "USDOMR", 0.385039 },
                    { "USDPAB", 0.99811 },
                    { "USDPEN", 3.29025 },
                    { "USDPGK", 3.36905 },
                    { "USDPHP", 52.675039 },
                    { "USDPKR", 139.985038 },
                    { "USDPLN", 3.79235 },
                    { "USDPYG", 6135.050374 },
                    { "USDQAR", 3.641104 },
                    { "USDRON", 4.206504 },
                    { "USDRSD", 104.240373 },
                    { "USDRUB", 64.60369 },
                    { "USDRWF", 900.005 },
                    { "USDSAR", 3.750304 },
                    { "USDSBD", 8.088204 },
                    { "USDSCR", 13.648504 },
                    { "USDSDG", 47.515504 },
                    { "USDSEK", 9.277204 },
                    { "USDSGD", 1.35261 },
                    { "USDSHP", 1.320904 },
                    { "USDSLL", 8900.000339 },
                    { "USDSOS", 581.000338 },
                    { "USDSRD", 7.458038 },
                    { "USDSTD", 21050.59961 },
                    { "USDSVC", 8.733704 },
                    { "USDSYP", 515.000338 },
                    { "USDSZL", 14.360504 },
                    { "USDTHB", 31.670504 },
                    { "USDTJS", 9.42185 },
                    { "USDTMT", 3.5 },
                    { "USDTND", 3.006038 },
                    { "USDTOP", 2.25715 },
                    { "USDTRY", 5.763038 },
                    { "USDTTD", 6.778904 },
                    { "USDTWD", 30.883038 },
                    { "USDTZS", 2339.450368 },
                    { "USDUAH", 26.847038 },
                    { "USDUGX", 3695.450367 },
                    { "USDUSD", 1.0 },
                    { "USDUYU", 33.296038 },
                    { "USDUZS", 8360.750367 },
                    { "USDVEF", 9.987504 },
                    { "USDVND", 23157.1 },
                    { "USDVUV", 112.0 },
                    { "USDWST", 2.613006 },
                    { "USDXAF", 579.440365 },
                    { "USDXAG", 0.064792 },
                    { "USDXAU", 0.000761 },
                    { "USDXCD", 2.70265 },
                    { "USDXDR", 0.718551 },
                    { "USDXOF", 579.440364 },
                    { "USDXPF", 105.350364 },
                    { "USDYER", 250.350364 },
                    { "USDZAR", 14.492504 },
                    { "USDZMK", 9001.203593 },
                    { "USDZMW", 11.982037 },
                    { "USDZWL", 322.355011 }
                }
            };

            return await Task.FromResult(currencyQuotesModel);
        }
    }
}
