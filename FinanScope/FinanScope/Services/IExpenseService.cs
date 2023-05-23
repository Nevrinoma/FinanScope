using FinanScope.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanScope.Services
{
    public interface IExpenseService
    {
        Task<List<Expense>> GetExpensesAsync();
        Task AddExpenseAsync(Expense expense);
        Task UpdateExpenseAsync(Expense expense);
        Task DeleteExpenseAsync(int id);
    }
}
