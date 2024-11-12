using BMIMonitor.ValueTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMonitor.ReferenceTypes
{
    using BMIMonitor.ValueTypes;
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public double BMI {  get; private set; }

        public void CalculateBMI() 
        {
            var measurement = new Measurement(Weight, Height);
            BMI = measurement.BMI;
        }
    }
}
