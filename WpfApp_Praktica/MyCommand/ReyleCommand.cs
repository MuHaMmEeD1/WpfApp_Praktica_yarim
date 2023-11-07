﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_Praktica.MyCommand
{
    public class ReyleCommand : ICommand
    {


        private readonly Action<object?>? _action;
        private readonly Predicate<object?>? _predicate;

        public ReyleCommand(Action<object?>? action, Predicate<object?>? predicate)
        {
            _action = action;
            _predicate = predicate;
        }

        public event EventHandler? CanExecuteChanged
        {
            add {

                CommandManager.RequerySuggested += value;
            } 
            
            remove {

                CommandManager.RequerySuggested -= value;
            }



        }

        public bool CanExecute(object? parameter)
        {
            return _predicate!.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _action?.Invoke(parameter);
        }
    }
}
