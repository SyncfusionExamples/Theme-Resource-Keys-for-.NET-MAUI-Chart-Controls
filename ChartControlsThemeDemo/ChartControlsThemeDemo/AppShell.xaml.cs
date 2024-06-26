using Microsoft.Maui.Controls;

namespace ChartControlsThemeDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("page1", typeof(CartesianChartDemo));
            Routing.RegisterRoute("page2", typeof(CircularChartDemo));
            Routing.RegisterRoute("page3", typeof(FunnelChartDemo));
            Routing.RegisterRoute("page4", typeof(PyramidChartDemo));
            Routing.RegisterRoute("page5", typeof(SunburstChartDemo));
        }
    }
}