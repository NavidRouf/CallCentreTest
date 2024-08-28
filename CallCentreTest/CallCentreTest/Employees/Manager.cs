using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest.Employees
{
    internal class Manager : Employee, ICallHandler
    {
        private bool isUnavailable;
        private Call? currentCall;

        private Director director;

        public Manager(string name, Director director) : base(name)
        {
            isUnavailable = false;
            this.director = director;
        }

        public int RecieveCall(Call call)
        {
            if (isUnavailable)
            {
                return -1;
            }

            currentCall = call;
            Thread callThread = new Thread(HandleCall);
            callThread.Start();
            return 0;
        }

        public ICallHandler GetHandlerToForward()
        {
            return director;
        }

        void HandleCall()
        {
            isUnavailable = true;
            currentCall.callAction();
            isUnavailable = false;
            currentCall = null;
        }
    }
}
