using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class FunnelViewModel
    {
        public ObservableCollection<FunnelModel> FunnelData { get; set; }
        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public FunnelViewModel()
        {
            FunnelData = new ObservableCollection<FunnelModel>
            {
                 new FunnelModel("Renewed", 18),
                 new FunnelModel("Subscribed", 34),
                 new FunnelModel("Contacted Support", 52),
                 new FunnelModel("Downloaded a Trial", 68),
                 new FunnelModel("Visited the Website", 100),
           };

            PaletteBrushes = new ObservableCollection<Brush>()
            {
                 new SolidColorBrush(Color.FromArgb("#314A6E")),
                 new SolidColorBrush(Color.FromArgb("#48988B")),
                 new SolidColorBrush(Color.FromArgb("#5E498C")),
                 new SolidColorBrush(Color.FromArgb("#74BD6F")),
                 new SolidColorBrush(Color.FromArgb("#597FCA"))
            };
        }
    }
}