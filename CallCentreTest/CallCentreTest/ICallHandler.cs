using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest
{
    internal interface ICallHandler
    {
        int RecieveCall(Call call);
        ICallHandler GetHandlerToForward();
    }
}
