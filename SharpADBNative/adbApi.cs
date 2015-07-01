using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SharpAdbNative {
    public static class adbApi {
        [StructLayout(LayoutKind.Sequential)]
        public struct myGuid {
            public UInt32 Data1;
            public UInt16  Data2;
            public UInt16  Data3;
            public fixed byte Data4[8];
        }

        public static Guid ANDROID_USB_CLASS_ID = new Guid("F72FE0D4-CBCB-407d-8814-9ED673D0DD6B");
    }
}
