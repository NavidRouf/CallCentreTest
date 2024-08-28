using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCentreTest.Employees;

namespace CallCentreTest
{
    internal class CallCentre
    {
        private List<Employee> allEmployees = new List<Employee>();
        private List<ICallHandler> allRespondants = new List<ICallHandler>();
        private Queue<ICallHandler> availableRespondants = new Queue<ICallHandler>();

        public Manager Manager { get; private set; }


        public CallCentre(Manager manager)
        {
            Manager = manager;
            allEmployees.Add(manager);
        }


        public void DispatchCall(Call call)
        {
            if (availableRespondants.Count > 0)
            {
                var currentRespondant = availableRespondants.Dequeue();
                SendCallTo(call, currentRespondant);
            }
            else
            {
                SendCallTo(call, Manager);
            }
        }

        //recursion so that it can forward the call if the current person is unavailable
        private void SendCallTo(Call call, ICallHandler handler)
        {
            var response = handler.RecieveCall(call);
            if (response == -1)
            {
                SendCallTo(call, handler.GetHandlerToForward());
            }
        }


        public void NowAvailable(ICallHandler handler)
        {
            availableRespondants.Enqueue(handler);
        }

        public void AddEmployee(Employee employee)
        {
            allEmployees.Add(employee);
            if (employee is ICallHandler handler)
            {
                allRespondants.Add(handler);
                availableRespondants.Enqueue(handler);
            }
        }

        public void AddEmployee(List<Employee> employees)
        {
            foreach (var e in employees)
            {
                AddEmployee(e);
            }
        }
        
    }
}
