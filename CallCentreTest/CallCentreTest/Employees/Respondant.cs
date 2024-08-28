using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest.Employees
{
    internal class Respondant : Employee, ICallHandler
    {
        private bool isHandingCall;
        private Call? currentCall;

        private CallCentre callCentre;


        public Respondant(string name, CallCentre callCentre) : base(name)
        {
            isHandingCall = false;
            this.callCentre = callCentre;
        }

        public int RecieveCall(Call call)
        {
            if (isHandingCall)
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
            return callCentre.Manager;
        }

        void HandleCall()
        {
            isHandingCall = true;
            currentCall.callAction();
            isHandingCall = false;
            currentCall = null;
        }
    }
}
