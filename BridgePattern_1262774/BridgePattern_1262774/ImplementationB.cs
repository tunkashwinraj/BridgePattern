using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_1262774
{
    public class ImplementationB : IBridge
    {
        public string OperationImp()
        {
            return "result from ImplementationB operation";
        }

        public string AnotherOperationImp(string msg)
        {
            return "GreetingsB and Welcome " + msg;
        }
    }

}
