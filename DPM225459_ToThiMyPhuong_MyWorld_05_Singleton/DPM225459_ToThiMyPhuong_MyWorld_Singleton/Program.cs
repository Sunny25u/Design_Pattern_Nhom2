using System;
using System.Collections.Generic;

namespace DPM225459_ToThiMyPhuong_MyWorld_Singleton
{
    // --- CLIENT PROGRAM ---
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo danh sách phòng khách sạn
            RoomCollection hotel = new RoomCollection();
            hotel[0] = new Room(101, "Deluxe", true);
            hotel[1] = new Room(102, "Standard", false);
            hotel[2] = new Room(103, "Suite", true);
            hotel[3] = new Room(104, "Standard", true);
            hotel[4] = new Room(105, "Deluxe", false);

            // Tạo iterator
            RoomIterator iterator = hotel.CreateIterator();

            // Duyệt cách 1 phòng
            iterator.Step = 1;

            Console.WriteLine("Danh sách phòng còn trống:");

            // Duyệt các phòng còn trống
            for (Room room = iterator.First(); !iterator.IsDone; room = iterator.Next())
            {
                if (room.IsAvailable)
                    Console.WriteLine($"Phòng {room.RoomNumber} - Loại: {room.RoomType}");
            }

            Console.ReadKey();
        }
    }
}