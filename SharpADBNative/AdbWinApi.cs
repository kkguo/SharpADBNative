using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SharpAdbNative {
    public static class AdbWinApi {
        [DllImport("AdbWinApi", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr AdbEnumInterfaces(Guid class_id,bool exclude_not_present, bool exclude_removed, bool active_only);
        
        [DllImport("AdbWinUsbApi", SetLastError = true)]
        public static extern bool AdbCloseHandle(IntPtr adb_handle);

        [DllImport("AdbWinUsbApi", SetLastError = true)]
        public static extern IntPtr AdbCreateInterfaceByName(string interface_name);

        [DllImport("AdbWinUsbApi", SetLastError = true)]
        public static extern bool AdbGetEndpointInformation(IntPtr adb_interface, byte endpoint_index, AdbEndpointInformation info);

        //[DllImport("AdbWinUsbApi", SetLastError = true)]
        //AdbGetInterfaceName
        //AdbGetSerialNumber
        //AdbGetUsbDeviceDescriptor
        //AdbGetUsbInterfaceDescriptor
        //AdbNextInterface
        //AdbOpenDefaultBulkReadEndpoint
        //AdbOpenDefaultBulkWriteEndpoint
        //AdbReadEndpointSync
        //AdbWriteEndpointSync

        public enum AdbEndpointType {
          /// Unknown (invalid, or not initialized) endpoint type.
          AdbEndpointTypeInvalid = 0,

          /// Endpoint is device control pipe.
          AdbEndpointTypeControl,

          /// Endpoint is isochronous r/w pipe.
          AdbEndpointTypeIsochronous,

          /// Endpoint is a bulk r/w pipe.
          AdbEndpointTypeBulk,

          /// Endpoint is an interrupt r/w pipe.
          AdbEndpointTypeInterrupt,
        };

        public struct AdbEndpointInformation {
          /// Maximum packet size this endpoint is capable of.
          UInt32 max_packet_size;

          /// Maximum size of one transfer which should be sent to the host controller.
          UInt32 max_transfer_size;

          /// ADB endpoint type.
          AdbEndpointType endpoint_type;

          /// Raw endpoint address on the device as described by its descriptor.
          byte endpoint_address;

          /// Polling interval.
          byte polling_interval;

          /// Which alternate setting this structure is relevant for.
          byte setting_index;
        }

    }

}
