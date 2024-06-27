using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Syncfusion.Maui.Themes;

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

        private void switch_StateChanged(object sender, Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs e)
        {
            var state = e.NewValue;
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
                if (theme != null)
                {
                    if (state == false)
                    {
                        theme.VisualTheme = SfVisuals.MaterialLight;
                        Application.Current.UserAppTheme = AppTheme.Light;
                        
                    }
                    else
                    {
                        theme.VisualTheme = SfVisuals.MaterialDark;
                        Application.Current.UserAppTheme = AppTheme.Dark;
                    }
                }
            }
        }
    }
}