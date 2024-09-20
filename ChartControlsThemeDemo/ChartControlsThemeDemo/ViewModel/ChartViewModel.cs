using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class ChartViewModel
    {
        public ObservableCollection<Brush> PaletteBrushes { get; set; }
        public ObservableCollection<Brush> CustomBrush { get; set; }
        public ObservableCollection<ChartModel> LineData1 { get; set; }
        public ObservableCollection<ChartModel> LineData2 { get; set; }
        public ObservableCollection<ChartModel> PieSeriesData { get; set; }
        public ObservableCollection<ChartModel> FunnelData { get; set; }
        public ObservableCollection<ChartModel> PyramidData { get; set; }
        public ObservableCollection<ChartModel> SunburstData { get; set; }

        public ChartViewModel()
        {
            PaletteBrushes = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#314A6E")),
               new SolidColorBrush(Color.FromArgb("#48988B")),
               new SolidColorBrush(Color.FromArgb("#5E498C")),
               new SolidColorBrush(Color.FromArgb("#74BD6F")),
               new SolidColorBrush(Color.FromArgb("#597FCA"))
            };


            CustomBrush = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#2A9AF3")),
               new SolidColorBrush(Color.FromArgb("#0DC920")),
               new SolidColorBrush(Color.FromArgb("#F5921F")),
               new SolidColorBrush(Color.FromArgb("#E64191")),
               new SolidColorBrush(Color.FromArgb("#2EC4B6")),
            };

            LineData1 = new ObservableCollection<ChartModel>
            {
                new ChartModel("2005", 21),
                new ChartModel("2006", 24),
                new ChartModel("2007", 36),
                new ChartModel("2008", 38),
                new ChartModel("2009", 54),
                new ChartModel("2010", 57),
                new ChartModel("2011", 70)
            };

            LineData2 = new ObservableCollection<ChartModel>
            {
                new ChartModel("2005", 28),
                new ChartModel("2006", 44),
                new ChartModel("2007", 48),
                new ChartModel("2008", 50),
                new ChartModel("2009", 66),
                new ChartModel("2010", 78),
                new ChartModel("2011", 84)
            };

            PieSeriesData = new ObservableCollection<ChartModel>
            {
                new ChartModel("David", 16.6),
                new ChartModel("Steve", 14.6),
                new ChartModel("Jack", 18.6),
                new ChartModel("John", 20.5),
                new ChartModel("Regev", 39.5),
           };

            FunnelData = new ObservableCollection<ChartModel>
            {
                 new ChartModel("Renewed", 18),
                 new ChartModel("Subscribed", 34),
                 new ChartModel("Contacted Support", 52),
                 new ChartModel("Downloaded a Trial", 68),
                 new ChartModel("Visited the Website", 100),
           };

            PyramidData = new ObservableCollection<ChartModel>
            {
                 new ChartModel("Passive Verbal",50),
                 new ChartModel("Discussion", 50),
                 new ChartModel("Practice", 75),
                 new ChartModel("Teach Others", 90),
            };

            SunburstData = new ObservableCollection<ChartModel>
            {
                new ChartModel(11, "Q1", "Jan"),
                new ChartModel(8, "Q1", "Feb"),
                new ChartModel(5, "Q1", "Mar"),
                new ChartModel(13, "Q2", "Apr"),
                new ChartModel(12, "Q2","May"),
                new ChartModel(17, "Q2","Jun"),
                new ChartModel(5, "Q3", "Jul"),
                new ChartModel(4, "Q3","Aug"),
                new ChartModel(5, "Q3","Sep"),
                new ChartModel(7, "Q4","Oct"),
                new ChartModel(18, "Q4", "Nov"),
                new ChartModel(5, "Q4", "Dec", "W1"),
                new ChartModel(5, "Q4", "Dec", "W2"),
                new ChartModel(5, "Q4", "Dec", "W3"),
                new ChartModel(5, "Q4", "Dec", "W4"),
            };
        }
    }
}