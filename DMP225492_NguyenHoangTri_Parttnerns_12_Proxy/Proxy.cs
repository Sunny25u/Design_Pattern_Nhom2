using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Parttnerns_12_Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
