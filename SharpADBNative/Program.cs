using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpAdbNative {
    class Program {
        
        static Guid kAdbInterfaceId = adbApi.ANDROID_USB_CLASS_ID;

        static void Main(string[] args) {
            IntPtr enum_handle = AdbWinApi.AdbEnumInterfaces(kAdbInterfaceId,true,true,true);
            if (null == enum_handle) {
                Console.WriteLine("\nEnum interface failure:");
                Console.WriteLine("\nUnable to enumerate ADB interfaces:");
                return;
            }
        }
    }
}
