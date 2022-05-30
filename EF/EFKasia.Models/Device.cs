using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKasia.Models
{
    public class Device
    {
        private string _name;
        public Device(string name)
        {
           _name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public int Size { get; set; }
        public int Weight { get; set; }
    }
}
