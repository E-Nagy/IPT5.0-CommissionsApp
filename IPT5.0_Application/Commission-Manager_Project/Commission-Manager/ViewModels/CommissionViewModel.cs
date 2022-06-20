using Commission_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commission_Manager.Views;
using Commission_Manager.Commands;
using System.Windows.Input;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace Commission_Manager.ViewModels
{
    internal class CommissionViewModel
    {

        private Commission _Commission;

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class
        /// </summary>
        public CommissionViewModel()
        {
            _Commission = new Commission("TestTitle", DateTime.Now);
            UpdateCommand = new CommissionUpdateCommand(this);
        }


        /// <summary>
        /// Gets the Update Command for the VeiwModel
        /// </summary>
        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a System.Boolean value indicating if Commission
        /// can be updated or not
        /// </summary>
        public bool CanUpdate
        {
            get
            {
                if (Commission == null)
                {
                  return false;
                }
                return !String.IsNullOrWhiteSpace(Commission.Title);

            }
        }

        /// <summary>
        /// Gets the Commission instance
        /// </summary>
        public Commission Commission
        {
            get { return _Commission; }
        }

        /// <summary>
        /// Tells CHanges have been saved
        /// TODO: Save Changes To .txt File
        /// </summary>
        public void SaveChanges()
        {
            MessageBox.Show("Changes have been saved.");
        }



        

    }
}
