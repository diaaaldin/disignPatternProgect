using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    interface Icecream
    {
        string MakeIcecream();
        double price();
    }
    public class IcecreamDecoratePattern
    {
      
    }



    abstract class IcecreamDecorate : Icecream
    {
        private readonly Icecream _icecream;

        public IcecreamDecorate(Icecream icecream)
        {
            _icecream = icecream;
        }
        public virtual string MakeIcecream()
        {
            return _icecream.MakeIcecream();
        }

        public virtual double price()
        {
            return _icecream.price();
        }
    }

    class IcecreamWithHoney : IcecreamDecorate
    {
        public IcecreamWithHoney(Icecream icecream) : base(icecream)
        {

        }
        public override string MakeIcecream()
        {
            string s = base.MakeIcecream() + " with Honey";
            return s;
        }
        public override double price()
        {
            double p = base.price() + 0.25;
            return p;
        }
    }


    class IcecreamWithNutty : IcecreamDecorate
    {
        public IcecreamWithNutty(Icecream icecream) : base(icecream)
        {

        }

        public override string MakeIcecream()
        {
            string s = base.MakeIcecream() + " with Nutty";
            return s;
        }
        public override double price()
        {
            double p = base.price() + 0.20;
            return p;
        }

    }

    public class SimpleIcecream : Icecream
    {

        public string MakeIcecream()
        {
            string s = " Ice Cream";
          
            return s;
        }

        public double price()
        {
            double p = 2;
            return p;
        }
    }
}
