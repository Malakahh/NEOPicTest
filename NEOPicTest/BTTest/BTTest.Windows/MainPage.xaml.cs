using System;
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
using Windows.UI.Xaml.Documents;
using Windows.Devices.Enumeration;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BTTest
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //f4f232be5a5311e68b7786f30ca893d3
            /*
            var Services = await DeviceInformation.FindAllAsync(GattDeviceService.GetDeviceSelectorFromUuid(new Guid("e0cbf06ccd8b4647bb8a263b43f0f974")));
            GattDeviceService Service = await GattDeviceService.FromIdAsync(Services[0].Id);
            GattCharacteristic gattCharacteristic = Service.GetCharacteristics(new Guid("1d4b745a5a5411e68b7786f30ca893d3"))[0];

            GattReadResult res = await gattCharacteristic.ReadValueAsync();
            string s = res.Value.ToString();

            Paragraph p = new Paragraph();
            p.Inlines.Add(new Run() { Text = s });
            rtb.Blocks.Add(p);
            */
        }
    }
}
