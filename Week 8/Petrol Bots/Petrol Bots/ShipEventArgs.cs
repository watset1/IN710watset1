using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Bots
{
    public enum EShipState {WANDERING, REFUELING};

    public class ShipEventArgs : EventArgs
    {
        Point shipLocation;
        public Point ShipLocation { get; set; }

        public ShipEventArgs(Point shipLocation)
        {
            ShipLocation = this.shipLocation = shipLocation;
        }
    }
}
