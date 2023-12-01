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

namespace ObserverEditor.GameProject
{
    /// <summary>
    /// Interaction logic for Projects.xaml
    /// </summary>
    public partial class Projects : Window
    {
        public Projects()
        {
            InitializeComponent();
        }
        private void OnToggleButton_click(object sender, RoutedEventArgs e)
        {
            if(sender == OpenProject)
            {
                if (CreateProject.IsChecked == true)
                {
                    OpenProject.IsEnabled = false;
                    CreateProject.IsChecked = false;
                    Dialog.Margin = new Thickness(0);
                }
                CreateProject.IsEnabled = true;
            }
            else
            {
                if (OpenProject.IsChecked == true)
                {
                    CreateProject.IsEnabled = false;
                    OpenProject.IsChecked = false;
                    Dialog.Margin = new Thickness(-800 ,0 ,0 ,0);
                }
                OpenProject.IsEnabled = true;
            }
        }
    }
}
