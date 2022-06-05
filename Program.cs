using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your Container type ");
            Console.WriteLine("If you whant icecream in ");
            Console.WriteLine("Biscuit inter : 1");
            Console.WriteLine("Cup inter : 2");
            string Container = Console.ReadLine();
            int Cont = Convert.ToInt16(Container);


            Console.WriteLine("Write your Icecream extention");
            Console.WriteLine("If you don't whant extention inter : 0");
            Console.WriteLine("whant a nutty extention inter : 1");
            Console.WriteLine("whant a Hunny extention inter : 2");
            string IcecreamExtention = Console.ReadLine();
            int Ice = Convert.ToInt16(IcecreamExtention);

            Console.WriteLine("Write your payment method");
            Console.WriteLine("If you whant to pay with ");
            Console.WriteLine("cash card inter : 1");
            Console.WriteLine("Dibit card inter : 2");
            Console.WriteLine("pay a cash without any card inter : 3");
            string paymentMethod = Console.ReadLine();
            int pay = Convert.ToInt16(paymentMethod);

            Console.WriteLine("Write your Delevary method");
            Console.WriteLine("If you whant to delevary with");
            Console.WriteLine("Car inter : 1");
            Console.WriteLine("Bike inter : 2");
            string DelevaryMethod = Console.ReadLine();
            int Delevary = Convert.ToInt16(DelevaryMethod);

            Console.WriteLine();
            Console.WriteLine();

            if (Cont == 1)
            {
                CountenerTemplate biscuit = new Biscuit();
                biscuit.TypeOfContainer();
                biscuit.FillContainer();
                biscuit.FinalAddtion();
            } 
            else if (Cont == 2)
            {
                CountenerTemplate Cup = new Cub();
                Cup.TypeOfContainer();
                Cup.FillContainer();
                Cup.FinalAddtion();
            }
            else{
                Console.WriteLine("This Container is not exist");
            }

            ///////////////
            ///
         
            Console.WriteLine("Icecream type :");  
            if (Ice == 0)
            {
                Icecream icecream0 = new SimpleIcecream();
                Console.WriteLine(icecream0.MakeIcecream());
                Console.WriteLine("Total price = " + icecream0.price());


            }
            else if (Ice == 1)
            {
                Icecream icecream1 = new SimpleIcecream();
                IcecreamDecorate icecreamDecorate1 = new IcecreamWithNutty(icecream1);
                Console.WriteLine(icecreamDecorate1.MakeIcecream());
                Console.WriteLine("Total price = " + icecreamDecorate1.price());

            }
            else if (Ice == 2)
            {
                Icecream icecream2 = new SimpleIcecream();
                IcecreamDecorate icecreamDecorate2 = new IcecreamWithHoney(icecream2);
                Console.WriteLine(icecreamDecorate2.MakeIcecream());
                Console.WriteLine("Total price = " + icecreamDecorate2.price());
            }
            else
            {
                Console.WriteLine("your choise Not avalable");
            }
            Console.WriteLine();
            Console.WriteLine("Payment method :");
            /////////////////////////

            Customer customer = new Customer();
            customer.Pay(pay);

            /////////////////////////
            ///
            Console.WriteLine();
            Console.WriteLine("Delevary Method :");

            IVehicle car = new Car();
            IVehicle Bike = new BikeAdapter(new Bike());
            if (Delevary == 1)
            {
                UseVehicle(car);
            }
            else if (Delevary == 2 )
            {
                UseVehicle(Bike);

            }
            else
            {
                Console.WriteLine("your delevary choice is Not avalable");
            }

        }

        public static void UseVehicle(IVehicle vehicle)
        {
            vehicle.DelevaryDiscription();

            Console.WriteLine();
        }
    }
}
