using DMP225492_NguyenHoangTri_Real_17_SmartHome;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        SmartHomeHub hub = new SmartHomeHub();

        // Tạo thiết bị
        var light = new Light("Đèn phòng khách", hub);
        var fan = new Fan("Quạt trần", hub);
        var curtain = new Curtain("Rèm cửa", hub);
        var lightSensor = new LightSensor("Cảm biến ánh sáng", hub);
        var tempSensor = new TempSensor("\n Cảm biến nhiệt", hub);

        // Gán thiết bị vào Hub
        hub.light = light;
        hub.fan = fan;
        hub.curtain = curtain;

        // Mô phỏng tình huống
        lightSensor.DetectDark();
        tempSensor.DetectHot();
        tempSensor.DetectCool();

        Console.ReadKey();
    }
}

