using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    class AircraftComparer : IComparer<Plane>
    {
        public int Compare(Plane first, Plane second)
        {
            if (first.GetType().Name != second.GetType().Name)
            {
                return first.GetType().Name.CompareTo(second.GetType().Name);
            }
            
            if (first is SeaPlane && second is SeaPlane)
            {
                return ComparerSeaPlane(first as SeaPlane, second as SeaPlane);
            }
            if (first is Aircraft && second is Aircraft)
            {
                return ComparerAircraft(first as Aircraft, second as Aircraft);
            }
            return 0;
        }

        private int ComparerAircraft(Aircraft first, Aircraft second)
        {
            if (first.MaxSpeed != second.MaxSpeed)
            {
                return first.MaxSpeed.CompareTo(second.MaxSpeed);
            }
            if (first.Weight != second.Weight)
            {
                return first.Weight.CompareTo(second.Weight);
            }
            if (first.MainColor != second.MainColor)
            {
                return first.MainColor.Name.CompareTo(second.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSeaPlane(SeaPlane first, SeaPlane second)
        {
            int result = ComparerAircraft(first, second);
            if (result != 0)
            {
                return result;
            }
            if (first.DopColor != second.DopColor)
            {
                return first.DopColor.Name.CompareTo(second.DopColor.Name);
            }
            if (first.Bobber != second.Bobber)
            {
                return first.Bobber.CompareTo(second.Bobber);
            }
            if (first.Stripes != second.Stripes)
            {
                return first.Stripes.CompareTo(second.Stripes);
            }
           
            return 0;
        }
    }
}