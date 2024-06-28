using Syncfusion.Maui.Themes;

namespace ChartControlsThemeDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItemIndex == 0)
            {
                cartesian.IsVisible = true;
                circular.IsVisible = funnel.IsVisible = pyramid.IsVisible = sunburst.IsVisible = false;
            }
            else if(e.SelectedItemIndex == 1)
            {
                circular.IsVisible = true;
                cartesian.IsVisible = funnel.IsVisible = pyramid.IsVisible = sunburst.IsVisible = false;
            }
            else if(e.SelectedItemIndex == 2)
            {
                funnel.IsVisible = true;
                cartesian.IsVisible = circular.IsVisible = pyramid.IsVisible = sunburst.IsVisible = false;
            }
            else if(e.SelectedItemIndex == 3)
            {
                pyramid.IsVisible = true;
                cartesian.IsVisible = circular.IsVisible = funnel.IsVisible = sunburst.IsVisible = false;
            }
            else if(e.SelectedItemIndex == 4)
            {
                sunburst.IsVisible = true;
                cartesian.IsVisible = circular.IsVisible = funnel.IsVisible = pyramid.IsVisible = false;
            }
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