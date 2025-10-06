using System;

namespace Abstract.HotelManagement
{
    // --- CLIENT PROGRAM ---
    public class Program
    {
        public static void Main()
        {
            // Tạo và chạy khách sạn cao cấp
            var luxuryHotel = new HotelWorld<LuxuryBranch>();
            luxuryHotel.ShowServiceExperience();

            // Tạo và chạy khách sạn bình dân
            var budgetHotel = new HotelWorld<BudgetBranch>();
            budgetHotel.ShowServiceExperience();

            Console.ReadKey();
        }
    }

    // --- ABSTRACT FACTORY ---
    public interface IHotelBranchFactory
    {
        IRoom CreateRoom();
        IService CreateService();
    }

    // --- CONCRETE FACTORY 1 ---
    public class LuxuryBranch : IHotelBranchFactory
    {
        public IRoom CreateRoom() => new LuxuryRoom();
        public IService CreateService() => new SpaService();
    }

    // --- CONCRETE FACTORY 2 ---
    public class BudgetBranch : IHotelBranchFactory
    {
        public IRoom CreateRoom() => new StandardRoom();
        public IService CreateService() => new BasicCleaningService();
    }

    // --- ABSTRACT PRODUCT A ---
    public interface IRoom
    {
        string GetDescription();
    }

    // --- ABSTRACT PRODUCT B ---
    public interface IService
    {
        void Provide(IRoom room);
    }

    // --- CONCRETE PRODUCT A1 ---
    public class LuxuryRoom : IRoom
    {
        public string GetDescription() => "Phòng cao cấp với view biển và nội thất sang trọng";
    }

    // --- CONCRETE PRODUCT A2 ---
    public class StandardRoom : IRoom
    {
        public string GetDescription() => "Phòng tiêu chuẩn, đầy đủ tiện nghi cơ bản";
    }

    // --- CONCRETE PRODUCT B1 ---
    public class SpaService : IService
    {
        public void Provide(IRoom room)
        {
            Console.WriteLine($"Dịch vụ Spa đang phục vụ khách trong: {room.GetDescription()}");
        }
    }

    // --- CONCRETE PRODUCT B2 ---
    public class BasicCleaningService : IService
    {
        public void Provide(IRoom room)
        {
            Console.WriteLine($"Dịch vụ dọn phòng cơ bản đang thực hiện trong: {room.GetDescription()}");
        }
    }

    // --- CLIENT CLASS ---
    public class HotelWorld<T> where T : IHotelBranchFactory, new()
    {
        private readonly IRoom room;
        private readonly IService service;

        public HotelWorld()
        {
            // Tạo factory cho chi nhánh cụ thể
            var factory = new T();
            room = factory.CreateRoom();
            service = factory.CreateService();
        }

        public void ShowServiceExperience()
        {
            Console.WriteLine($"\n--- Trải nghiệm tại {typeof(T).Name} ---");
            Console.WriteLine(room.GetDescription());
            service.Provide(room);
        }
    }
}
