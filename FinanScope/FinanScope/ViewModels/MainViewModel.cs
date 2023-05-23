using FinanScope.Models;
using SQLite;
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
        private SQLiteConnection database;
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
        private ObservableCollection<Salary> salaries;
        public ObservableCollection<Salary> Salaries
        {
            get { return salaries; }
            set { SetProperty(ref salaries, value); }
        }
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Получить данные из базы данных и присвоить их свойству Salaries
            Salaries = new ObservableCollection<Salary>(database.Table<Salary>());
        }

        public MainViewModel()
        {
            Expenses = new ObservableCollection<ExpenseViewModel>();
            // inicializatsija i zagruzka
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
