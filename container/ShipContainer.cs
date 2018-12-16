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

        public ShipContainer(Container container) : base(container.Height, container.Width, container.Type, container.Weight)
        {
            Assigned = false;
        }
        public ShipContainer(Container container, bool assigned) : base(container.Height, container.Width, container.Type, container.Weight)
        {
            Assigned = assigned;
        }
    }
}
