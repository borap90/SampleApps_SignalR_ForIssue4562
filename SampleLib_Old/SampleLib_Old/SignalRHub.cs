using Microsoft.AspNet.SignalR;
using System;
using System.Runtime.InteropServices;

namespace SampleLib_Old
{
    [Guid("5BA12413-97FF-4181-99A4-0A8849FF725E")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("TestLibrary.Program")]
    public class SignalRHub : Hub, COMInterfaceSignalR
    {
        public void Fire_PrintComplete()
        {
            try
            {
                var context = GlobalHost.ConnectionManager.
                              GetHubContext<SignalRHub>();
                context.Clients.All.PrintComplete();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
