using System;
using System.Collections.Generic;
using System.Text;

namespace FinanScope.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
