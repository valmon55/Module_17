using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patters.Final
{
    public class NameByID
    {
        public string GetName(INameByID nameByID, int i) 
        {
            return nameByID.GetName(i);
        }
    }
}
