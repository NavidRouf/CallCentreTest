using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest.Employees
{
    internal class Director : Employee, ICallHandler
    {
        public Director(string name) : base(name)
        {

        }

        public ICallHandler GetHandlerToForward()
        {
            throw new Exception("Director has no superior");
        }

        public int RecieveCall(Call call)
        {
            return 0;
        }
    }
}
