using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patters.Final
{
    public class Month : INameByID
    {
        const int TotalCount = 12;
        public String GetName(int day)
        {
            string name = day switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => //throw new InvalidOperationException($"День недели должен быть в диапазоне 1 to {TotalCount}")
                    $"День недели должен быть в диапазоне 1 to {TotalCount}",
            };

            Console.WriteLine($"Номер {day} --> " + name);

            return name;
        }
    }
}
