using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Commission_Manager.ViewModels;

namespace Commission_Manager.Commands
{
    internal class CommissionUpdateCommand : ICommand
    {
        private CommissionViewModel _CommissionViewModel;

        /// <summary>
        /// Initializes a new instance of the CustomerUpdate class
        /// </summary>
        /// <param name="viewModel"></param>
        public CommissionUpdateCommand(CommissionViewModel viewModel)
        {
            _CommissionViewModel = viewModel;
        }


        /// <summary>
        /// Implementation of the Interface ICommand
        /// This needs to be wired up back to the WPF command
        /// system since it is implemented locally
        /// </summary>
        #region ICommandMembers

        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object? parameter)
        {
            return _CommissionViewModel.CanUpdate;
        }

        public void Execute(object? parameter)
        {
            _CommissionViewModel.SaveChanges();
        }

        #endregion
    }
}

