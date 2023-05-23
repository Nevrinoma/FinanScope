using FinanScope.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
        public void LoadSalaries()
        {
            Salaries = new ObservableCollection<Salary>(database.Table<Salary>().ToList());
            OnPropertyChanged(nameof(Salaries));
        }





        public MainViewModel()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Salary>();

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
