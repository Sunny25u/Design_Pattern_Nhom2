using DPM225407_NguyenHuuDuy_MyWord_02_Builder;
class Program
{
    static void Main()
    {
        var shop = new Shop();
        var carBuilder = new CarBuilder();

        shop.Construct(carBuilder);
        carBuilder.Vehicle.Show();
    }
}
