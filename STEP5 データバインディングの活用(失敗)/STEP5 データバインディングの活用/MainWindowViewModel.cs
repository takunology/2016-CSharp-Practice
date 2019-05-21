using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace STEP5_データバインディングの活用
{
    public class MainWindowViewModel : ViewModel
    {
        private double metricValue, imperialValue;

        public ICommand ImperialUnitToMetric { get; private set; }
        public ICommand MetricToImperialUnit { get; private set; }

        public MetricUnit CurrentMetricUnit { get; private set; }
        public ImperialUnit CurrentImperialUnit { get; private set; }

        public double MetricValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue
        {
            get { return this.imperialValue; }
            set
            {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }

        }

        public MainWindowViewModel()
        {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();
            this.MetricToImperialUnit = new DelegateCommand(() => this.ImperialValue = this.CurrentImperialUnit.FromMetricUnit(this.CurrentMetricUnit, this.MetricValue));
            this.ImperialUnitToMetric = new DelegateCommand(() => this.MetricValue = this.CurrentImperialUnit.FromImperialUnit(this.CurrentImperialUnit, this.ImperialValue));
        }

    }
}
