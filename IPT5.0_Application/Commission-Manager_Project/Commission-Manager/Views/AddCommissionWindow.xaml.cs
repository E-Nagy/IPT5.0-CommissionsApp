using Commission_Manager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Commission_Manager.Views
{
    /// <summary>
    /// Binding View to Viewmodel
    /// </summary>
    public partial class AddCommissionWindow : Window
    {
        public AddCommissionWindow()
        {
            InitializeComponent();

            DataContext = new CommissionViewModel();
        }
    }
}
