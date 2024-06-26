using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartControlsThemeDemo
{
    public class PyramidModel
    {
        public string XValue { get; set; }
        public double YValue { get; set; }

        public PyramidModel(string xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }
    }
}
