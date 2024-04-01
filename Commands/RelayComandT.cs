﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice4.Commands
{
    public class RelayCommand<T> : RelayCommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> execute) : this(execute, null) { }
        public RelayCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(_execute));
            _canExecute = canExecute;
        }
        public override bool CanExecute(object parameter) => _canExecute == null||_canExecute((T)parameter);
        public override void Execute(object parameter) => _execute((T)parameter);
    }
}
