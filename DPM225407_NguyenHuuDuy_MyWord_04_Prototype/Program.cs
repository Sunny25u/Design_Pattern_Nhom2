using DPM225407_NguyenHuuDuy_MyWord_04_Prototype;
class Program
{
    static void Main()
    {
        var h1 = new HinhChuNhat(10, 5);
        var h2 = (HinhChuNhat)h1.Clone();

        h2.Dai = 20; // thay đổi bản sao

        h1.HienThi(); // vẫn giữ nguyên
        h2.HienThi(); // bản sao đã đổi
    }
}
