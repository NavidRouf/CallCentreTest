using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest
{
    internal class Call
    {
        public Action callAction {  get; }
        
        //callAction can be used to create a "script" for dialouge with outputs to console and Thread.Sleep statements
        public Call(Action callAction)
        {
            this.callAction = callAction;
        }
    }
}
