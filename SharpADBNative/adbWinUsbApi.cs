using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SharpAdbNative {
    public static class AdbWinUsbApi {
        [DllImport("AdbWinUsbApi",SetLastError=true)]
        public static extern IntPtr InstantiateWinUsbInterface(String interface_name);
    }
}
