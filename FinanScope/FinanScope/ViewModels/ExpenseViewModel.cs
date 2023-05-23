using FinanScope.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinanScope.ViewModels
{
    public class ExpenseViewModel : INotifyPropertyChanged
    {
        private Expense _expense;

        public Expense Expense
        {
            get { return _expense; }
            set
            {
                _expense = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
