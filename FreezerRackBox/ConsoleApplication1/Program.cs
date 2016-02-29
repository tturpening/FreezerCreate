using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rack = new List<string> { "LN3", "LN3" };
            List<string> box = new List<string> { "1", "2", "3" };
            List<string> lat = new List<string> { "A", "B", "C", "D" };
            List<string> lng = new List<string> { "1", "2", "3", "4" };

            List<Freezer> freezer = new List<Freezer>();

            foreach (var _box in box.Select((value, index) => new { value, index }))
            {
                foreach (var _lat in lat.Select((value, index) => new { value, index }))
                {
                    Console.WriteLine(rack[0] + ":" + _box.value + "-" + _lat.value + "/" + lng[_lat.index]);
                }
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
    class Freezer
    {
        public string Rack { get; set; }
        public List<string> Box { get; set; }
        public List<string> Location { get; set; }
    }
    class Box
    {
        public string box { get; set; }
    }
    class Location
    {
        public string location { get; set; }
    }
}

