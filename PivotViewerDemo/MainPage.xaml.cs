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
            var output = new StringBuilder();
            foreach (var i in Enumerable.Range(126, 206)) output.Append(i + ",");

            //this.pivotViewer.View = this.pivotViewer.GraphView;
            //this.pivotViewer.Loaded += pivotViewer_Loaded;
        }

        void pivotViewer_Loaded(object sender, RoutedEventArgs e)
        {
            //this.pivotViewer.Filter = "CouponToday=GE.5_LE.10";
            //this.pivotViewer.SelectionChanged += pivotViewer_SelectionChanged;
            //var filterRoot = (Grid) this.FindName("FilterPaneRoot");
            //var dropShadow = (Rectangle)filterRoot.Children[0];
            //filterRoot.Children.Remove(dropShadow);

            //var filterRoot = this.FindName("FilterPaneRoot");
            //VisualTreeHelper.(pivotViewer);
            //var dropShadow = (UIElement)VisualTreeHelper.GetChild(filterRoot, 0);
            //filterRoot.Children.Remove(dropShadow);

            //(UIElement) VisualTreeHelper.GetChild(this.pivotViewer);
        }

        //void pivotViewer_SelectionChanged(object sender, EventArgs e)
        //{
        //    string filter = pivotViewer.Filter;
        //    string inScopeItems = pivotViewer.InScopeItems.Count.ToString();
        //    string viewId = pivotViewer.View.Id;

        //    MessageBox.Show(string.Format("Filter: {1}{0}InScopeItems.Count: {2}{0}View: {3}",
        //                                    Environment.NewLine,
        //                                    filter,
        //                                    inScopeItems,
        //                                    viewId));
        //}

        private void GetCommands(object sender, PivotViewerCommandsRequestedEventArgs e)
        {
            e.Commands.Add(new AdornerCommand(e.Item as Price));
        }
    }
}
