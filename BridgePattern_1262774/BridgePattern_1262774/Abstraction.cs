using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_1262774
{
    public class Abstraction
    {
        protected IBridge bridge;

        public Abstraction(IBridge br) // Client's view uses aggregation
        {
            bridge = br;
        }

        public string Operation()
        {
            return "Abstraction: " + bridge.OperationImp();
        }

        public string OperationGreet(string nm)
        {
            return "Abstraction: " + bridge.AnotherOperationImp(nm);
        }
    }

}
