using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commission_Manager.ViewModels;
using Commission_Manager.Commands;

namespace Commission_Manager.Models
{
    public class Commission : INotifyPropertyChanged
    {
        private string _Title;
        private DateTime _TakenOn;


        /// <summary>
        /// Initializes new instance of the Commission class
        /// </summary>
        public Commission(string Title, DateTime takenOn)
        {

        }


        /// <summary>
        /// Gets or sets the Commission's Title
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value;
                OnPropertyChanged("Title");
            }
        }


        /// <summary>
        /// Gets or sets the Date the commission has been taken on
        /// </summary>
        public DateTime TakenOn
        {
            get { return _TakenOn; }
            set
            {
                _TakenOn = value;
                OnPropertyChanged("TakenOn");
            }
        }


        /// <summary>
        /// Sends Notification in form of the property name
        /// when it is changed
        /// </summary>
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion 
    }
}
