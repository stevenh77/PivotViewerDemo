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
            
            this.pivotViewer.View = this.pivotViewer.GraphView;
            //this.pivotViewer.Loaded += pivotViewer_Loaded;
        }

        void pivotViewer_Loaded(object sender, RoutedEventArgs e)
        {
            //this.pivotViewer.Filter = "CouponToday=GE.5_LE.10";
        }

        private void GetCommands(object sender, PivotViewerCommandsRequestedEventArgs e)
        {
            e.Commands.Add(new AdornerCommand(e.Item as Price));
        }
    }
}
