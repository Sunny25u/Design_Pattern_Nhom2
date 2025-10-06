using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225459_ToThiMyPhuong_MyWorld_Factory_Method
{
    public abstract class Section
    {
        public override string ToString() => GetType().Name;
    }

    // --- CÁC CONCRETE PRODUCT (các phần cụ thể của hóa đơn) ---
    public class CustomerInfoSection : Section { }
    public class RoomDetailsSection : Section { }
    public class PaymentDetailsSection : Section { }
    public class ServiceDetailsSection : Section { }
    public class FoodDetailsSection : Section { }
    public class TaxSection : Section { }
    public class SummarySection : Section { }
}
