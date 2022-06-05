using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    public abstract class CountenerTemplate
    {
        //   sealed = final
        public sealed void TemplateDesignMethode()
        {
            TypeOfContainer();
            FillContainer();
            FinalAddtion();
        }
        public abstract void TypeOfContainer();
        public void FillContainer()
        {
            Console.WriteLine("2 : full it in icecreame");
        }
        public abstract void FinalAddtion();
    }


    public class Biscuit : CountenerTemplate
    {
       
        public override void TypeOfContainer()
        {
            Console.WriteLine("Methods of operation ");
           Console.WriteLine("1 : Take a biscuit");
        }
        public override void FinalAddtion()
        {
            Console.WriteLine("3 : Add a crached biscuit");
            Console.WriteLine();
        }
    }


    public class Cub : CountenerTemplate
    {
       

        public override void TypeOfContainer()
        {
            Console.WriteLine("Methods of operation ");
            Console.WriteLine("1 : Take a Cab");
        }
        public override void FinalAddtion()
        {
            Console.WriteLine("3 : Add spone and chery");
            Console.WriteLine();

        }
    }

}
