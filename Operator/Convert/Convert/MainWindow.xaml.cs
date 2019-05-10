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

namespace Convert
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //double x = System.Convert.ToDouble(tb1.Text);
            //double y = System.Convert.ToDouble(tb2.Text);
            double x = double.Parse(tb1.Text);
            double y = double.Parse(tb2.Text);
            double result = x + y;
            this.tb3.Text = System.Convert.ToString(result);
        }
    }
}
