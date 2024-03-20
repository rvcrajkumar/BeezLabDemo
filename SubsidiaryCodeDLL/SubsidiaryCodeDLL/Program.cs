using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsidiaryCodeDLL
{
    public class SubsidiaryCodeClass : MarshalByRefObject
    {
        public string ProcessData(int input)
        {
            // Example: Add custom logic here to process the input
            return $"Received: {input.ToString()}, Processed by SubsidiaryCodeDLL is : {(input*2).ToString()} .";
        }
    }
}
