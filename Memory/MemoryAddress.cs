using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public unsafe static class MemoryAddress
    {
        public static string Get(object obj)
        {
            TypedReference tr = __makeref(obj);
            IntPtr ptr = **(IntPtr**)(&tr);
            return "0x" + ptr.ToString("X");
        }

        public static string Get(ref object obj)
        {
            TypedReference tr = __makeref(obj);
            IntPtr ptr = **(IntPtr**)(&tr);
            return "0x" + ptr.ToString("X");
        }
    }
}
