using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class CircularViewModel
    {
        public ObservableCollection<CircularModel> PieSeriesData { get; set; }
        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public CircularViewModel()
        {
            PieSeriesData = new ObservableCollection<CircularModel>
            {
                new CircularModel("David", 16.6),
                new CircularModel("Steve", 14.6),
                new CircularModel("Jack", 18.6),
                new CircularModel("John", 20.5),
                new CircularModel("Regev", 39.5),
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
