using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    public class Pc
    {
        private string model;
        private string processorclockspeed;
        private string theamountofRAM;
        private string harddiskspase;

        public Pc(string model, string processorclockspeed, string theamountofRAM, string harddiskspase)
        {
            this.model = model;
            this.processorclockspeed = processorclockspeed;
            this.theamountofRAM = theamountofRAM;
            this.harddiskspase = harddiskspase;
        }

        public void InfoPc()
        {
            Console.WriteLine(model);
            Console.WriteLine(processorclockspeed);
            Console.WriteLine(theamountofRAM);
            Console.WriteLine(harddiskspase);
            Console.WriteLine();
        }
    }
}
