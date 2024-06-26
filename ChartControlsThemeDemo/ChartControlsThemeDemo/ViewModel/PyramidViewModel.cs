using System;
using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class PyramidViewModel
    {
        public ObservableCollection<PyramidModel> PyramidData { get; set; }
        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public PyramidViewModel()
        {
            PyramidData = new ObservableCollection<PyramidModel>
            {
                 new PyramidModel("Passive Verbal",50),
                 new PyramidModel("Discussion", 50),
                 new PyramidModel("Practice", 75),
                 new PyramidModel("Teach Others", 90),
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