using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinanScope.ViewModels
{
    public class SalaryViewModel : BaseViewModel
    {
        private decimal totalAmount;
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { SetProperty(ref totalAmount, value); }
        }

        private decimal monthlySalary;
        public decimal MonthlySalary
        {
            get { return monthlySalary; }
            set { SetProperty(ref monthlySalary, value); }
        }

        public ICommand AddSalaryCommand { get; }

        public SalaryViewModel()
        {
            AddSalaryCommand = new Command(AddSalary);
        }

        private void AddSalary()
        {
            // Реализуйте логику добавления зарплаты
        }
    }
}
