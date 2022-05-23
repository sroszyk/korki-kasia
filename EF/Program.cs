using EFKasia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKasia
{
    internal class Program
    {
        static string ToLoweCaseLetter(string text)
        {
            return text.ToLower();
        }

        static void Main(string[] args)
        {
            using(var ctx = new FirstDbContext())
            {
                var names = ctx.Devices.Select(x => ToLoweCaseLetter(x.Name));
                foreach(var name in names)
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadKey();
        }

    }
}
