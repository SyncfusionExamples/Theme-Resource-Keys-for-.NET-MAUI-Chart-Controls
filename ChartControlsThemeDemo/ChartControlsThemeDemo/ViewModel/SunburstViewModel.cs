using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class SunburstViewModel
    {
        public ObservableCollection<SunburstModel> DataSource { get; set; }
        public ObservableCollection<Brush> CustomBrush { get; set; }
        public SunburstViewModel()
        {
            DataSource = new ObservableCollection<SunburstModel>
            {
                new SunburstModel(11, "Q1", "Jan"),
                new SunburstModel(8, "Q1", "Feb"),
                new SunburstModel(5, "Q1", "Mar"),
                new SunburstModel(13, "Q2", "Apr"),
                new SunburstModel(12, "Q2","May"),
                new SunburstModel(17, "Q2","Jun"),
                new SunburstModel(5, "Q3", "Jul"),
                new SunburstModel(4, "Q3","Aug"),
                new SunburstModel(5, "Q3","Sep"),
                new SunburstModel(7, "Q4","Oct"),
                new SunburstModel(18, "Q4", "Nov"),
                new SunburstModel(5, "Q4", "Dec", "W1"),
                new SunburstModel(5, "Q4", "Dec", "W2"),
                new SunburstModel(5, "Q4", "Dec", "W3"),
                new SunburstModel(5, "Q4", "Dec", "W4"),
            };

            CustomBrush = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#2A9AF3")),
               new SolidColorBrush(Color.FromArgb("#0DC920")),
               new SolidColorBrush(Color.FromArgb("#F5921F")),
               new SolidColorBrush(Color.FromArgb("#E64191")),
               new SolidColorBrush(Color.FromArgb("#2EC4B6")),
            };
        }
    }
}
