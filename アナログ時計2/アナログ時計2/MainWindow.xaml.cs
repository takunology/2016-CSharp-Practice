﻿using System;
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

namespace アナログ時計2
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

        public void timer_tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            double secondRad = 2 * Math.PI / 60 * dt.Second;
            double minuteRad = 2 * Math.PI / 60 * dt.Minute;
            double hourRad = 2 * Math.PI / 720 * ((dt.Hour % 12) * 60 + dt.Minute);

            SecondLine.X2 = Math.Sin(secondRad) * 10;
            SecondLine.Y2 = Math.Cos(secondRad) * 10;
            MinuteLine.X2 = Math.Sin(minuteRad) * 10;
            MinuteLine.Y2 = Math.Cos(minuteRad) * 10;
            HourLine.X2 = Math.Sin(hourRad) * 10;
            HourLine.Y2 = Math.Cos(hourRad) * 10;

        }
    }
}
