using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225459_ToThiMyPhuong_MyWorld_Singleton
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int number, string type, bool available)
        {
            RoomNumber = number;
            RoomType = type;
            IsAvailable = available;
        }

        public interface IRoomCollection
        {
            RoomIterator CreateIterator();
        }
    }
}
