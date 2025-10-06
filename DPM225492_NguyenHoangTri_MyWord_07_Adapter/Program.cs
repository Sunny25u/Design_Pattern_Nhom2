using System;

namespace DPM225492_NguyenHoangTri_MyWord_07_Adapter
{
    // Interface client muốn dùng
    public interface IUsbDevice
    {
        void ConnectWithUsbCable();
    }

    // Class không tương thích (đã có sẵn)
    public class VgaDevice
    {
        public void ConnectWithVgaCable()
        {
            Console.WriteLine("Kết nối với cáp VGA");
        }
    }

    // Adapter giúp VgaDevice hoạt động như IUsbDevice
    public class VgaToUsbAdapter : IUsbDevice
    {
        private VgaDevice _vgaDevice;

        public VgaToUsbAdapter(VgaDevice vgaDevice)
        {
            _vgaDevice = vgaDevice;
        }

        public void ConnectWithUsbCable()
        {
            // Chuyển đổi gọi phương thức tương ứng
            _vgaDevice.ConnectWithVgaCable();
        }
    }

    // Client code
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Bạn có 1 thiết bị VGA
            VgaDevice vga = new VgaDevice();

            // Tạo adapter để sử dụng như USB device
            IUsbDevice usbDevice = new VgaToUsbAdapter(vga);

            // Dùng thiết bị qua adapter
            usbDevice.ConnectWithUsbCable();
        }
    }
}
