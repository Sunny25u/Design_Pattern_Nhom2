using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225480_DinhQuocThanh_Myword13_Chain_of_Responsibility
{
    public class Director : Approver
    {
        protected override bool CanApprove(Purchase purchase)
        {
            return purchase.Amount < 5000;
        }

        protected override void Approve(Purchase purchase)
        {
            Console.WriteLine($"{GetType().Name} approved request #{purchase.Number} for {purchase.Purpose} with amount {purchase.Amount}");
        }
    }
}
