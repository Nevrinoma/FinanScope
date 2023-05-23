using FinanScope.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.IO;


namespace FinanScope.ViewModels
{
    public class SalaryViewModel : BaseViewModel
    {
        private SQLiteConnection database;


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

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Salary>();
        }


        private void AddSalary()
        {
            if (MonthlySalary > 0)
            {
                var newSalary = new Salary { Amount = MonthlySalary, Date = DateTime.Now };
                database.Insert(newSalary);

                //+отображение
            }
        }

    }
}
