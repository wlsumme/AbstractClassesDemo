using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle() 
        {

        }

        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract moto");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Virtual moto");
        }
    }
}
