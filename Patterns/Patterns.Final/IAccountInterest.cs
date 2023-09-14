using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Final
{
    public interface IAccountInterest
    {
        public double CalculateInterest(Account account);
    }
}
