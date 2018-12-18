using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class ShipContainer : Container
    {
        public bool Assigned { get; set; }
        public ShipPosition Position { get; set; }

        public ShipContainer(string type, int weight) : base(type, weight)
        {
            Assigned = false;
            Position = new ShipPosition();
        }

        public override string ToString()
        {
            return string.Format("Type:{0} Weight:{1}", Type, Weight);
        }
    }
}
