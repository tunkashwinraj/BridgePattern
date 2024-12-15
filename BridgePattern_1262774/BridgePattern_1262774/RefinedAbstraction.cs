using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_1262774
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IBridge br) : base(br)
        {
        }

        public string OperationGreetTime(string nm)
        {
            return "RefinedAbstraction: " + bridge.AnotherOperationImp(nm) +
                   " : Time of call = " + DateTime.Now.ToString();
        }
    }

}
