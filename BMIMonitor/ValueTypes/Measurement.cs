using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMonitor.ValueTypes
{
    public struct Measurement
    {
        public double BMI {  get; }
        public Measurement(double weight, double height) 
        {
            BMI = weight / (height * weight);
        }
    }
}
