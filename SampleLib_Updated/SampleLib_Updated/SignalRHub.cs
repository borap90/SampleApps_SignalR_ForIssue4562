using Microsoft.AspNet.SignalR;
using System;
using System.Runtime.InteropServices;

namespace SampleLib_Updated
{
    [Guid("3427873B-5C6B-41A5-834B-F2AA49D1101A")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("SampleLibrary_Updated.Program")]
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
