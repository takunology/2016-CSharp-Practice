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

namespace アンケート受付アプリ講座用
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        String s, p, g, name;
        public MainWindow()
        {
            InitializeComponent();   
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(radioButton.IsChecked == true)
            {
                s = "男";
            }
            else
            {
                s = "女";
            }

            if(radioButton2.IsChecked == true)
            {
                g = "１年生";
            }
            else if(radioButton3.IsChecked == true)
            {
                g = "2年生";
            }
            else if(radioButton4.IsChecked == true)
            {
                g = "3年生";
            }

            if(radioButton5.IsChecked == true)
            {
                p = "アプリ";
            }
            else
            {
                p = "アルゴリズム";
            }

            name = textBox.Text;

            MessageBox.Show("回答者:"+ name + "\n" + "Q1:" + s + " " + "Q2:" + g + " " + "Q3:" + p);
        }
    }
}
