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
            List<string> lat = new List<string> { "A", "B" };
            List<string> lng = new List<string> { "1", "2" };

            List<Freezer> freezer = new List<Freezer>();

            foreach (var _box in box.Select((value, index) => new { value, index }))
            {
                Console.WriteLine(_box.value);
                Console.WriteLine("count value: " +_box.index.ToString());               
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
    class Freezer
    {
        public string Rack { get; set; }
        public string Box { get; set; }
        public string Location { get; set; }
    }
}

