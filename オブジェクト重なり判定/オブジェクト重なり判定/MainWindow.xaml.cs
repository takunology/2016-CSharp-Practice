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

namespace オブジェクト重なり判定
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Rect position1 = new Rect();
            position1.Location = label.PointToScreen(new Point(10, 10));
            position1.Height = label.ActualHeight;
            position1.Width = label.ActualWidth;

            Rect position2 = new Rect();
            position2.Location = label1.PointToScreen(new Point(10, 10));
            position2.Height = label1.ActualHeight;
            position2.Width = label1.ActualWidth;

            if (position1.IntersectsWith(position2))
            {
                textBlock.Text = "重なっとる";
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Key key = e.Key;
            if(e.Key == Key.Up)
            {
                
            }
        }
    }
}
