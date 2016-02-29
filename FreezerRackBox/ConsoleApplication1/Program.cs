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
            List<string> lat = new List<string> { "A", "B" };
            List<string> lng = new List<string> { "1", "2" };

            List<Freezer> freezer = new List<Freezer>();
        }
    }
    class Freezer
    {
        public string Rack { get; set; }
        public string Box { get; set; }
        public string Location { get; set; }
    }
}

