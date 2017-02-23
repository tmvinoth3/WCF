using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace myfirstwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
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
        }
        public int add(int a, int b)
        {
            return a + b;
        }

        string IService1.GetData(int value)
        {
            return value.ToString();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            return composite;
        }

        int IService1.add(int a, int b)
        {
            return a + b;
        }
    }
}
