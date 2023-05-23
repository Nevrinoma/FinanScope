using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinanScope.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ExpenseViewModel> _expenses;

        public ObservableCollection<ExpenseViewModel> Expenses
        {
            get { return _expenses; }
            set
            {
                _expenses = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Expenses = new ObservableCollection<ExpenseViewModel>();
            // Здесь можно добавить код инициализации и загрузки данных
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
