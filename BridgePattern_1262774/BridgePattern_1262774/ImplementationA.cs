using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_1262774
{
    public class ImplementationA : IBridge
    {
        public string OperationImp()
        {
            return "result from ImplementationA operation";
        }

        public string AnotherOperationImp(string msg)
        {
            return "Greetings " + msg;
        }
    }

}
