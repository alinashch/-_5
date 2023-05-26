using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public abstract class Car : Vehicle
    {
        public int maxspeed { get; set; }
        public string color { get; set; }

        public string name { get; set; }

        public string Start()
        {
            string s= name +" speed " + maxspeed;
           // Console.WriteLine(s);
            return s;
        }

        public string Stop()
        {
            string s = name + " stop ";
            //Console.WriteLine(s);
            return s;
        }

        public abstract bool freight();
        public abstract string information();
        
    }
}
