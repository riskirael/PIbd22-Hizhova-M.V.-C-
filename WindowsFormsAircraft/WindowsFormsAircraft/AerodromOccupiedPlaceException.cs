using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class AerodromOccupiedPlaceException:Exception
    {
        public AerodromOccupiedPlaceException(int i) : base("Место по номеру " + i+" занято")
        { }
    }
}
