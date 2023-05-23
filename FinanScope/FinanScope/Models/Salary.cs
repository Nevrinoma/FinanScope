using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanScope.Models
{

    public class Salary
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
