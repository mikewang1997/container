using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Ship
    {
        public int ShipHeight { get; set; }
        public int ShipWidth { get; set; }
        //In tons
        public int Weight { get; set; }
        public int RowAmount { get; set; }
        public int ColumnAmount { get; set; }
        public Container[,] Grid { get; set; }
        public List<Container> ListContainer { get; set; }

        public Ship(int shipHeight, int shipWidth, int weight, int rowAmount, int columnAmount, List<Container> ListContainer)
        {
            int totalContainerWeight;
            foreach (Container container in ListContainer)
            {
                totalContainerWeight =+ container.Height;
            }

            ShipHeight = shipHeight;
            ShipWidth = shipWidth;
            Weight = weight;
            RowAmount = rowAmount;
            ColumnAmount = columnAmount;
        }

        public bool shipWeightRequirements(int shipWeight, List<Container> ListContainer)
        {
            int totalContainerWeight = 0;

            foreach (Container container in ListContainer)
            {
                totalContainerWeight =+ container.Height;
            }

            if (totalContainerWeight >= (shipWeight/2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
