using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Bluetooth;
using Windows.Devices.Enumeration;
using System.Threading.Tasks;

namespace App2
{
    class BluetoothImplementation
    {
        // Define BLE current device getters and setters.  
        public BluetoothLEDevice currentDevice { get; set; }
        // Define the selectedCharacteristic variable.  
        private GattCharacteristic selectedCharacteristic;
        // Define the selectedService variable.  
        private GattDeviceService selectedService;
        private const int CHARACTERISTIC_INDEX = 0;
        private const GattClientCharacteristicConfigurationDescriptorValue CHARACTERISTIC_NOTIFICATION_TYPE = GattClientCharacteristicConfigurationDescriptorValue.Notify;
        public async Task<BluetoothLEDevice> getDevices(string deviceName)
        {
            foreach (DeviceInformation di in await DeviceInformation.FindAllAsync(BluetoothLEDevice.GetDeviceSelector()))
            {
                BluetoothLEDevice bleDevice = await BluetoothLEDevice.FromIdAsync(di.Id);
                //Out of the list of devices available to the computer the specific one is selected and added to the device list.
                if (bleDevice != null && bleDevice.Name == deviceName)
                {
                    currentDevice = bleDevice;
                    Debug.WriteLine(bleDevice.Name);
                }
                break;
            }
            return currentDevice;
        }
        public GattDeviceService selectService(BluetoothLEDevice device, Guid service)
        {
            return selectedService = device.GetGattService(service);
        }
        public GattCharacteristic selectCharacteristic(GattDeviceService service, Guid characteristic)
        {
            return selectedCharacteristic = service.GetCharacteristics(characteristic)[CHARACTERISTIC_INDEX];
        }
        public async Task<byte[]> read()
        {
            byte[] response = (await selectedCharacteristic.ReadValueAsync()).Value.ToArray();
            Array.Reverse(response, 0, response.Length);
            return response;
        }
        public async Task<GattCommunicationStatus> write(GattCharacteristic characteristic, byte[] data)
        {
            return await characteristic.WriteValueAsync(data.AsBuffer(), GattWriteOption.WriteWithResponse);
        }

    }
}
