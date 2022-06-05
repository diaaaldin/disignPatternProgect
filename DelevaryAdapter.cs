using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    public interface IVehicle
    {
        void DelevaryDiscription();

    }
    public class DelevaryAdapter
    {

    }
    public class Bike
    {
        public void BikeDescription()
        {
            Console.WriteLine("Delevary is a Bike and has a tot tot tot sound");
        }

    }

    internal class BikeAdapter : IVehicle
    {
        private Bike _bike;
        public BikeAdapter(Bike bike)
        {
            _bike = bike;
        }
        public void DelevaryDiscription()
        {
            _bike.BikeDescription();
        }


    }

    internal class Car : IVehicle
    {
        public void DelevaryDiscription()
        {
            Console.WriteLine("Delevary is a Car and has a beb beb beb sound");
        }

    }
}
