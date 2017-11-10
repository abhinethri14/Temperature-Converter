using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Temperature1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
		
		public double c2f(double c)
		{
			double f;
			f=(c*(double)9/5)+32;  // Formula to calculate Fahrenheit using Celsius
			return (f);
		}
		
		public double f2c(double f)
		{
			double c;
			c=(f-32)*(double)5/9; // Formula to calculate Celsius using Fahrenheit
			return (c);
		}	
			
        /* public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

         public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite; 
        }  */
    }
}
