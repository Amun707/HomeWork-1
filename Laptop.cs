using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    public class Laptop
    {
        private string model;
        private string processorclockspeed;
        private string theamountofRAM;
        private string harddiskspase;
        private string weight;

        public Laptop(string model, string processorclockspeed, string theamountofRAM, string harddiskspase, string weight) 
        {
            this.model = model;
            this.processorclockspeed = processorclockspeed;
            this.theamountofRAM = theamountofRAM;
            this.harddiskspase = harddiskspase;
            this.weight = weight;
        }

        public void InfoLaptop()
        {
            Console.WriteLine(model);
            Console.WriteLine(processorclockspeed);
            Console.WriteLine(theamountofRAM);
            Console.WriteLine(harddiskspase);
            Console.WriteLine(weight);
        }
    }
}
