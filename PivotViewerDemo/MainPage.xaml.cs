using System.Windows.Controls.Pivot;

namespace PivotViewerDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.pivotViewer.ItemsSource = Factory.GetData();

            this.pivotViewer.ItemTemplates = new PivotViewerItemTemplateCollection()
                {
                    (PivotViewerItemTemplate) Resources["PriceTemplate"]
                };

            this.pivotViewer.SortPivotProperty = (PivotViewerProperty)this.pivotViewer.PivotProperties[5];

            //this.pivotViewer.View = this.pivotViewer.GraphView;
        }
    }
}
