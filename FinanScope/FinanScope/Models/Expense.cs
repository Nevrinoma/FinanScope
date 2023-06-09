﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinanScope.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
