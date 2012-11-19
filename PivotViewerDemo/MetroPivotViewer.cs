using System.Windows.Controls;
using System.Windows.Controls.Pivot;

namespace PivotViewerDemo
{
    public class MetroPivotViewer : PivotViewer
    {
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var partContainer = (Grid)this.FindName("PART_FilterPane");
            var part = (Grid)this.FindName("PART_ViewportArea");

            //var partContainer = (Grid)this.GetTemplateChild("PART_FilterPane");
            //var part = (Grid) this.GetTemplateChild("PART_ViewportArea");
            //var cvv = partContainer.Children[0];
            //var viewModel = ViewBehaviors.GetViewModel(cvv);
            //var model = ViewBehaviors.GetModel(this.View.);
        }
    }
}
