using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Patters.Final
{
    public class WeekDay : INameByID
    {
        const int TotalCount = 7;
        public String GetName(int day)
        {            
            string name = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ =>
                    //throw new InvalidOperationException($"День недели должен быть в диапазоне 1 to {TotalCount}")
                    $"День недели должен быть в диапазоне 1 to {TotalCount}"
            };

            Console.WriteLine($"Номер {day} --> " + name);

            return name;
        }

    }
}
