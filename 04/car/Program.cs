using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{
    class plane
    {
        public plane()
        {
            this.brand = "";
            this.model = "";
            this.TractionForce = 0;
            this.PassengerCapacity = 0;
            this.color = "white";
        }
        private int TractionForce { get; set; }
        private int PassengerCapacity { get; set; }
        private string model { set; get; }
        private string brand { set; get; }
        private string color { set; get; }
        public void get_info()
        {
            Console.WriteLine("Brand - {0}", brand);
            Console.WriteLine("Model - {0}", model);
            Console.WriteLine("Horse powers - {0}", TractionForce);
            Console.WriteLine("Volume - {0}", PassengerCapacity);
            Console.WriteLine("Color - {0}", color);
        }
        public void get_engine_info()
        {
            Console.WriteLine($"Traction Force - {TractionForce}");            
        }
        public void get_passenger_info()
        {
            Console.WriteLine($"Passenger Capacity {PassengerCapacity}");
        }






    }
}