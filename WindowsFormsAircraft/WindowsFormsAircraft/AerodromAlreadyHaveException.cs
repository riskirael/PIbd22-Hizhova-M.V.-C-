using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class AerodromAlreadyHaveException : Exception
    {
        public AerodromAlreadyHaveException() : base("На аэродроме уже есть такой самолет")
        { }
    }
}