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

        public ShipContainer(Container container) : base(container.Type, container.Weight)
        {
            Weight = container.Weight;
            Assigned = false;
            Position = new ShipPosition();
        }

        public override string ToString()
        {
            return string.Format("Column:{0} Row:{1} Stack:{2}", Position.Column, Position.Row, Position.Stack);
        }
    }
}
