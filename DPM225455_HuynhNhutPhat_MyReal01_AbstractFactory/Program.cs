using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225455_HuynhNhutPhat_MyReal01_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectFactory factory1 = new MathFactory();
            Lab lab1 = new Lab(factory1);
            lab1.Introduction();

            SubjectFactory factory2 = new PhysicFactory();
            Lab lab2 = new Lab(factory2);
            lab2.Introduction();

            Console.ReadKey();
        }
    }
}
