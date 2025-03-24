using RGB.NET.Core;
using RGB.NET.Devices.Razer;
using System.Threading.Tasks;

public class RazerRGBControl
{
    public static async Task SetAllRazerDevicesToBlue()
    {
        RGBSurface surface = RGBSurface.Instance;
        surface.Load(RazerDeviceProvider.Instance, throwExceptions: true);

        if (surface.Devices.Any())
        {
            var blueColor = new RGB.NET.Core.Color(0, 0, 255);
            foreach (var device in surface.Devices)
            {
                device.SetColor(blueColor);
            }
            surface.Update();
        }
    }
}