using System.Collections.ObjectModel;

namespace ChartControlsThemeDemo
{
    public class CartesianViewModel
    {
        public ObservableCollection<CartesianModel> LineData1 { get; set; }

        public ObservableCollection<CartesianModel> LineData2 { get; set; }

        public CartesianViewModel()
        {
            LineData1 = new ObservableCollection<CartesianModel>
            {
                new CartesianModel("2005", 21),
                new CartesianModel("2006", 24),
                new CartesianModel("2007", 36),
                new CartesianModel("2008", 38),
                new CartesianModel("2009", 54),
                new CartesianModel("2010", 57),
                new CartesianModel("2011", 70)
            };

            LineData2 = new ObservableCollection<CartesianModel>
            {
                new CartesianModel("2005", 28),
                new CartesianModel("2006", 44),
                new CartesianModel("2007", 48),
                new CartesianModel("2008", 50),
                new CartesianModel("2009", 66),
                new CartesianModel("2010", 78),
                new CartesianModel("2011", 84)
            };
        }
    }
}