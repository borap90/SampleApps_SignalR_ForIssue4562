using System;
using System.Runtime.InteropServices;

namespace SampleLib_Old
{
    [Guid("06FACA96-1FCD-4A91-95DB-D644705BE578")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface COMInterfaceSignalR
    {
        [DispId(1)]
        void Fire_PrintComplete();
    }
}
