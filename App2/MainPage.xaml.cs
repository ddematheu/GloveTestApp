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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        //All Motor Test
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;  
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp =  new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 7, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 1 Testing
        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 1, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 2 Testing
        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 2, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 3 Testing
        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 3, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 4 Testing
        private async void button4_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 4, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 5 Testing
        private async void button5_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 5, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
        //Motor 6 Testing
        private async void button6_Click(object sender, RoutedEventArgs e)
        {
            Guid serviceId = new Guid("15DB5D20-50D4-4370-A439-754E7182CB54");
            Guid characteristicId = new Guid("15DB5D21-50D4-4370-A439-754E7182CB54");
            List<string> characteristicList = new List<string>();
            GattCommunicationStatus status = 0;
            GattCharacteristic selectedCharacteristic;
            GattDeviceService selectedService;
            BluetoothLEDevice currentDevice;
            BluetoothImplementation imp = new BluetoothImplementation();
            currentDevice = await imp.getDevices("HapticGloveA");
            Debug.WriteLine(currentDevice);
            selectedService = imp.selectService(currentDevice, serviceId);
            Debug.WriteLine(selectedService.Uuid);
            selectedCharacteristic = imp.selectCharacteristic(selectedService, characteristicId);
            Debug.WriteLine(selectedCharacteristic.Uuid);
            byte[] data = { 6, 100, 100 };
            #region Implmentation definiton
            /*The current interface is as follows:
            [Motor(1 - 6 or 7). Each number corresponds to a motor, or 7 for all motors)]
            [Intensity(0..100 percent)]
            [Duration(1..100 percent of a second)]
            These values are sent in a byte array in the following format:
            [motor, intensity, duration]*/
            #endregion
            status = await imp.write(selectedCharacteristic, data);
            Debug.WriteLine(status);
        }
    }
}  
