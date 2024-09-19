namespace ChartControlsThemeDemo
{
    public class ChartModel
    {
        public string XValue { get; set; }
        public double YValue { get; set; }
        public double Sales { get; set; }
        public string? Quarter { get; set; }
        public string? Month { get; set; }
        public string? Week { get; set; }

        public ChartModel(double sales, string quarter, string month)
        {
            Sales = sales;
            Quarter = quarter;
            Month = month;
        }

        public ChartModel(double sales, string quarter, string month, string? week)
        {
            Sales = sales;
            Quarter = quarter;
            Month = month;
            Week = week;
        }

        public ChartModel(string xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }
    }
}