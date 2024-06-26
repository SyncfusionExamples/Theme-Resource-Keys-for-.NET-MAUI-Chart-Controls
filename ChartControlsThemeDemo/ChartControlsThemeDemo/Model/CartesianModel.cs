namespace ChartControlsThemeDemo
{
    public class CartesianModel
    {
        public string Year { get; set; }
        public double Value { get; set; }

        public CartesianModel( string year, double value)
        {
            Year = year;
            Value = value;
        }
    }
}