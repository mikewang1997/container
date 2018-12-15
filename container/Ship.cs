using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Ship
    {
        public int ShipHeight { get; private set; }
        public int ShipWidth { get; private set; }
        //In tons
        public int MaxWeight { get; private set; }
        public int CurrentWeight { get; private set; }
        public int RowAmount { get; private set; }
        public int ColumnAmount { get; private set; }
        public Container[,] Grid { get; private set; }
        public List<Container> ListContainer { get; private set; }

        public int MaxColumns { get; private set; }
        public int MaxRows{ get; private set; }

        //checking related
        public List<string> ListErrorMessages { get; set; }

        public Ship(int shipHeight, int shipWidth, int maxWeight, List<Container> listContainer)
        {
            ShipHeight = shipHeight;
            ShipWidth = shipWidth;
            MaxColumns = shipWidth / 5;
            MaxRows = shipHeight / 5;
            MaxWeight = maxWeight;
            ListContainer = listContainer;
            foreach (Container container in ListContainer)
            {
                CurrentWeight += container.Height;
            }
            ListContainer = listContainer;
            CreateGrid(this);

            ListErrorMessages = new List<string>();

            if (!shipMeetsRequirements(this))
            {

            }
        }

        private bool shipMeetsRequirements(Ship ship)
        {
            if (CurrentWeight >= (ship.MaxWeight/2))
            {
                return true;
            }
            else
            {
                ship.ListErrorMessages.Add("Schip voldoet niet aan de eis: minimaal 50% gewicht");
                return false;
            }
        }

        private void CreateGrid(Ship ship)
        {
            Dictionary<string, int> containerTypeCount = new Dictionary<string, int>();

            //Initialize the containerTypeCount
            for (int i = 0; i < Container.ListOfTypes.Count; i++)
            {
                containerTypeCount.Add(Container.ListOfTypes[i], 0);
            }
            
            //Count all the containerTypeCount
            foreach (Container container in ship.ListContainer)
            {
                for (int i = 0; i < Container.ListOfTypes.Count; i++)
                {
                    if (container.Type == Container.ListOfTypes[i])
                    {
                        containerTypeCount[Container.ListOfTypes[i]] += 1;
                        break;
                    }

                    if(i > Container.ListOfTypes.Count)
                    {
                        throw new ArgumentException("Container type is not correct, Check container ListOfTypes", "Container Type");
                    }
                }
            }
            //HIERAAN WERKEN
            for (int i = 0; i < ship.MaxColumns; i+=2)
            {
                if (containerTypeCount["Waardevolle"] < i)
                {
                    MaxRows = 50;
                    break;
                }
            }

        }

        private void calculateTotalColumns(Ship ship)
        {

        }

        private void calculateTotalRows(Ship ship)
        {

        }
    }
}
