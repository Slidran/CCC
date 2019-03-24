using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.Converter.Models
{
    public class ConverterModel
    {
        public string From { get; set; }
        public decimal Value { get; set; }
        public Dictionary<string, string> Currencies { get; set; }
        public Dictionary<string, double> Quotes { get; set; }
    }
}
