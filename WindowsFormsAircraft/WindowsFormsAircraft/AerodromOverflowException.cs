using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class AerodromOverflowException : Exception
    {
        public AerodromOverflowException() : base("На аэродроме нет свободных мест")
        { }
    }
}
