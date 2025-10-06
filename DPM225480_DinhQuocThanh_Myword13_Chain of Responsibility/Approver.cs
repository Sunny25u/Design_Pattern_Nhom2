using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225480_DinhQuocThanh_Myword13_Chain_of_Responsibility
{
    public abstract class Approver
    {
        protected Approver Successor { get; private set; }

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        // Phương thức xử lý yêu cầu
        public void ProcessRequest(Purchase purchase)
        {
            if (CanApprove(purchase))
            {
                Approve(purchase);
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
            else
            {
                Console.WriteLine($"Request #{purchase.Number} requires executive approval!");
            }
        }

        // Phương thức kiểm tra có thể phê duyệt hay không
        protected abstract bool CanApprove(Purchase purchase);

        // Phương thức phê duyệt
        protected abstract void Approve(Purchase purchase);
    }
}
