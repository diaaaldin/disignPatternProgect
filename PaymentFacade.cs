using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    public interface Payment
    {
        void Pay(int? x);
    }
    public class PaymentFacade
    {
      
    }
    internal class Customer : Payment
    {
        public void Pay(int? x)
        {
            FacadeClass facadeClass = new FacadeClass();
            facadeClass.Pay(x);
        }
    }
    internal class CashPay : Payment
    {
        public void Pay(int? x)
        {
            Console.WriteLine("Payment method is cash");
        }
    }

    internal class WithoutCardPay : Payment
    {
        public void Pay(int? x)
        {
            Console.WriteLine("Payment method is cash money without any card ");
        }
    }

   

    internal class DibitPay : Payment
    {
        public void Pay(int? x)
        {
            Console.WriteLine("Payment method is dibit");
        }
    }

    public class FacadeClass : Payment
    {
        public void Pay(int? x)
        {
            if (x.Equals(1))
            {
                CashPay cashPay = new CashPay();
                cashPay.Pay(null);
            }
            else if (x.Equals(2))
            {
                DibitPay dibitPay = new DibitPay();
                dibitPay.Pay(null);

            }
            else if (x.Equals(3))
            {
                WithoutCardPay criditPay = new WithoutCardPay();
                criditPay.Pay(null);
            }

        }
    }



    internal class Stuff : Payment
    {
        public void Pay(int? x)
        {
            throw new NotImplementedException();
        }
    }
}
