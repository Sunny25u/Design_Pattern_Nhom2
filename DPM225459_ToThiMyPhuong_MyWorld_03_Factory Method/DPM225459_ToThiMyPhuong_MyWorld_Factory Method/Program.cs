using System;
using System.Collections.Generic;

namespace Factory.HotelManagement
{
    // --- CLIENT PROGRAM ---
    public class Program
    {
        public static void Main()
        {
            // Các loại hóa đơn khác nhau
            List<Invoice> invoices = new List<Invoice>
            {
                new RoomBookingInvoice(),
                new ServiceInvoice(),
                new RestaurantInvoice()
            };

            // Duyệt và hiển thị chi tiết hóa đơn
            foreach (var invoice in invoices)
            {
                invoice.CreateSections(); // Factory Method

                Console.WriteLine($"{invoice} gồm các phần sau:");
                foreach (var section in invoice.Sections)
                    Console.WriteLine($" - {section}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
  
}
