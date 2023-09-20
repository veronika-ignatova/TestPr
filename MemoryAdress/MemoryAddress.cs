using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAddress
{
    public static class MemoryAddress
    {
        public static string Get(object a)
        {
            object o = new object();
            TypedReference tr = __makeref(o);
            IntPtr ptr = **(IntPtr**)(&tr);
            GCHandle handle = GCHandle.Alloc(a, GCHandleType.Pinned);
            IntPtr pointer = GCHandle.ToIntPtr(handle);
            handle.Free();
            return "0x" + pointer.ToString("X");
        }
    }
}
