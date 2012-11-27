using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Pivot;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PivotViewerDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.pivotViewer.ItemsSource = Factory.GetData();
            this.pivotViewer.Loaded += pivotViewer_Loaded;
        }

        void pivotViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIHelper.SetTimeout(5000, () => this.pivotViewer.View = this.pivotViewer.GraphView);

            //this.pivotViewer.Filter = "CouponToday=GE.5_LE.10";
        }

        private void GetCommands(object sender, PivotViewerCommandsRequestedEventArgs e)
        {
            e.Commands.Add(new AdornerCommand(e.Item as Price));
        }
    }

    public static class UIHelper
    {
        public static void SetTimeout(int milliseconds, Action func)
        {
            var timer = new DispatcherTimerContainingAction
            {
                Interval = new TimeSpan(0, 0, 0, 0, milliseconds),
                Action = func
            };
            timer.Tick += _onTimeout;
            timer.Start();
        }

        private static void _onTimeout(object sender, EventArgs arg)
        {
            var t = sender as DispatcherTimerContainingAction;
            t.Stop();
            t.Action();
            t.Tick -= _onTimeout;
        }
    }

    public class DispatcherTimerContainingAction : System.Windows.Threading.DispatcherTimer
    {
        public Action Action { get; set; }
    }
}
