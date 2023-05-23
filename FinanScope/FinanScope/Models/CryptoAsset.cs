using System;
using System.Collections.Generic;
using System.Text;

namespace FinanScope.Models
{
    public class CryptoAsset
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
