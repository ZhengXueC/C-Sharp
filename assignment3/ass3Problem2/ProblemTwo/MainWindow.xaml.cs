using ProblemTwo.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProblemTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculateFees mnc { get; set; } = null;
        public MainWindow()
        {
            mnc = new CalculateFees();
            InitializeComponent();
        }
        private void CalculateFees_Click(object sender, RoutedEventArgs e)
        {
            double weights = double.Parse(weight.Text);
            int mile = int.Parse(miles.Text);
            double fees=mnc.getCalculateFees(weights, mile);
            resultLabel.Content = $"Shipping Charges: ${fees:F2}";
        }
    }
}
