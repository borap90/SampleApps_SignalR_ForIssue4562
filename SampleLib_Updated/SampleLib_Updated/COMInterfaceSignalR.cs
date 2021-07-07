using System;
using System.Runtime.InteropServices;

namespace SampleLib_Updated
{
    [Guid("82FCCE5C-F417-4CAC-803D-1D47523DF1AF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface COMInterfaceSignalR
    {
        [DispId(1)]
        void Fire_PrintComplete();
    }
}
