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
using System.Windows.Threading;

namespace デジタル時計
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }


        void timer_tick(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToLongTimeString();
            label1.Content = DateTime.Today.ToLongDateString();
        }

    }
}
