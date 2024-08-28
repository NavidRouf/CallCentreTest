using CallCentreTest.Employees;

namespace CallCentreTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var ViktraMordenheim = new Director("Viktra Mordenheim");
            var Steve = new Manager("Steve", ViktraMordenheim);

            var LamordiaCallCentre = new CallCentre(Steve);

            var Jason = new Respondant("Jason", LamordiaCallCentre);
            var Jessica = new Respondant("Jessica", LamordiaCallCentre);
            var Joseph = new Respondant("Joseph", LamordiaCallCentre);

            LamordiaCallCentre.AddEmployee(new List<Employee>{ Jason, Jessica, Joseph });

            LamordiaCallCentre.DispatchCall(new Call(() =>
            {
                Console.WriteLine("Call1: Caller: Knock Knock.");
                Thread.Sleep(200);
                Console.WriteLine("Call1: Handler: Who's there?");
                Thread.Sleep(200);
                Console.WriteLine("Call1: Caller: who.");
                Thread.Sleep(200);
                Console.WriteLine("Call1: Handler: who who?");
                Thread.Sleep(200);
                Console.WriteLine("Call1: Caller: Wow I didn't expect to meet an owl!");
                Thread.Sleep(200);
                Console.WriteLine("Call1:  ------------- Call Terminated ------------- ");
            }));
            Thread.Sleep(200);
            LamordiaCallCentre.DispatchCall(new Call(() =>
            {
                Console.WriteLine("Call2: Caller: Knock Knock.");
                Thread.Sleep(200);
                Console.WriteLine("Call2: Handler: Sir this is Lamordia please go away");
                Thread.Sleep(200);
                Console.WriteLine("Call2:  ------------- Call Terminated ------------- ");
            }));
            Thread.Sleep(200);
            LamordiaCallCentre.DispatchCall(new Call(() =>
            {
                Console.WriteLine("Call3: Caller: Would you like to buy some limbs for trade? :) ");
                Thread.Sleep(200);
                Console.WriteLine("Call3: Handler: Ah yes, Dr. Viktra Mordenheim will be delighted for these!");
                Thread.Sleep(200);
                Console.WriteLine("Call3:  ------------- Call Terminated ------------- ");
            }));
            Thread.Sleep(200);
            LamordiaCallCentre.DispatchCall(new Call(() =>
            {
                Console.WriteLine("Call4: Caller: 911 please come help me I'm- ");
                Thread.Sleep(200);
                Console.WriteLine("Call4: Handler: Sir this is the Lamordian Call Centre, not 911.");
                Thread.Sleep(200);
                Console.WriteLine("Call4:  ------------- Call Terminated ------------- ");
            }));
            Thread.Sleep(200);
            LamordiaCallCentre.DispatchCall(new Call(() =>
            {
                Console.WriteLine("Call5: If the code works, this should not display");
                Thread.Sleep(200);
                Console.WriteLine("Call5:  ------------- Call Terminated ------------- ");
            }));
            Thread.Sleep(10000);
        }
    }
}
