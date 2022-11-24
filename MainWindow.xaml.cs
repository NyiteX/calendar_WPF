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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calendar calendar = new Calendar();
        public MainWindow()
        {
            InitializeComponent();
            Ini();
            Update();
        }
        public void Ini()
        {
            day_BIG.Content = DateTime.Now.Day;
            month_BIG.Content = DateTime.Now.ToString("MMMM");
            year_BIG.Content = DateTime.Now.Year;
        }
        public void Update()
        {
            var abv = calendar;
            MessageBox.Show(abv.ToString());
        }
    }
}
