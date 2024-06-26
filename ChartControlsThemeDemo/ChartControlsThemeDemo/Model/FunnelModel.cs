namespace ChartControlsThemeDemo
{
    public class FunnelModel
    {
        public string XValue { get; set; }
        public double YValue { get; set; }

        public FunnelModel(string xValue, double yValue)
        {
          XValue = xValue;
          YValue = yValue;
        }
    }
}