using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using WpfApp_Praktica.Models;
using WpfApp_Praktica.MyCommand;
using WpfApp_Praktica.Views;

namespace WpfApp_Praktica.ViewModels
{





    public class MainWindowViewModel : Notficetion
    {

        public ReyleCommand AddCommand { get; set; }

        public ObservableCollection<Person> Persons { get; set; }


        public NavigationWindow n;

        public MainWindowViewModel(NavigationWindow n)
        {
            Persons = new ObservableCollection<Person>();
            AddCommand = new ReyleCommand(_AddCommand, _CanAddCommand);

            Persons = JsonSerializer.Deserialize<ObservableCollection<Person>?>(File.ReadAllText("C:\\Users\\Nebiy_rk69\\source\\repos\\WpfApp_Praktica\\WpfApp_Praktica\\DataBase\\persons.json"));

            this.n = n;
            

            

        }



        public bool _CanAddCommand(object? pra)
        {
            if (pra != null) return true;


            return false;

        }

        public void _AddCommand(object? pra)
        {
            AddPage addPage = new AddPage();

            addPage.DataContext = new AddPageViewModel(Persons[Convert.ToInt32(pra)]);

            n.NavigationService.Navigate(new AddPage());

        }







    }
}
