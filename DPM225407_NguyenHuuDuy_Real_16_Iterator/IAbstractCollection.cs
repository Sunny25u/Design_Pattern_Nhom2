using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_Real_16_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
