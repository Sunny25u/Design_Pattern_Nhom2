using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPM225459_ToThiMyPhuong_MyWorld_Singleton.Room;

namespace DPM225459_ToThiMyPhuong_MyWorld_Singleton
{
    public class RoomCollection : IRoomCollection
    {
        private List<Room> rooms = new List<Room>();

        public RoomIterator CreateIterator()
        {
            return new RoomIterator(this);
        }

        public int Count => rooms.Count;

        public Room this[int index]
        {
            get { return rooms[index]; }
            set { rooms.Add(value); }
        }
    }

    // --- ITERATOR ---
    public interface IRoomIterator
    {
        Room First();
        Room Next();
        bool IsDone { get; }
        Room CurrentRoom { get; }
    }

}
