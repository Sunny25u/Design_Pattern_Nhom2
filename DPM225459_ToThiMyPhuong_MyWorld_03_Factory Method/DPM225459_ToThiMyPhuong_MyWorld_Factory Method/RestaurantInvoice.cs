using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225459_ToThiMyPhuong_MyWorld_Factory_Method
{
    public class RestaurantInvoice : Invoice
    {
        public override void CreateSections()
        {
            Sections = new List<Section>
            {
                new CustomerInfoSection(),
                new FoodDetailsSection(),
                new PaymentDetailsSection(),
                new TaxSection(),
                new SummarySection()
            };
        }
    }
}
}
