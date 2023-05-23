using FinanScope.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanScope.Services
{
    public class ExpenseService : IExpenseService
    {
        public async Task<List<Expense>> GetExpensesAsync()
        {
            return new List<Expense>();
            
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            
        }

        public async Task UpdateExpenseAsync(Expense expense)
        {
            
        }

        public async Task DeleteExpenseAsync(int id)
        {
            
        }
    }
}
