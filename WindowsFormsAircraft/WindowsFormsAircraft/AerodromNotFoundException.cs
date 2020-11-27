using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class AerodromNotFoundException : Exception
    {
        public AerodromNotFoundException(int i) : base("Не найден самолет по месту "+ i)
        { }
    }
}
