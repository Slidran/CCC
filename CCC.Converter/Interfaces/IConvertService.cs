using CCC.Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.Converter.Interfaces
{
    public interface IConvertService
    {
        Dictionary<string, decimal> Converter(ConverterModel converterModel);
    }
}
