namespace ChartControlsThemeDemo
{
    public class SunburstModel
    {
        public double Sales { get; set; }
        public string? Quarter { get; set; }
        public string? Month { get; set; }
        public string? Week { get; set; }

        public SunburstModel(double sales, string quarter, string month)
        {
            Sales = sales;
            Quarter = quarter;
            Month = month;
        }

        public SunburstModel(double sales, string quarter, string month, string? week) 
        {
            Sales = sales;
            Quarter = quarter;
            Month = month;
            Week = week;
        }
    }
}