using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225459_ToThiMyPhuong_MyWorld_Singleton
{
    public class RoomIterator : IRoomIterator
    {
        private RoomCollection collection;
        private int current = 0;
        private int step = 1;

        public RoomIterator(RoomCollection collection)
        {
            this.collection = collection;
        }

        public Room First()
        {
            current = 0;
            return collection[current];
        }

        public Room Next()
        {
            current += step;
            if (!IsDone)
                return collection[current];
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Room CurrentRoom
        {
            get { return collection[current]; }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
