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

namespace 時間練習１
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer _timer;
        TimeSpan _time;

        public MainWindow()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tdTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                
                if (tdTime.Text == "00:00:00")
                {
                    MessageBox.Show("時間切れ");
                }

            }, Application.Current.Dispatcher);

            _timer.Start();

        }
    }
}


  