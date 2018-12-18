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
        public int RowAmount { get; protected set; }
        public int ColumnAmount { get; protected set; }
        public int StackAmount { get; private set; }
        public ShipContainer[,,] Grid { get; private set; }
        public List<ShipContainer> ListContainer { get; private set; }

        public int MaxColumns { get; private set; }
        public int MaxRows { get; private set; }
        public int MaxStack { get; private set; }

        //checking related
        public List<string> ListErrorMessages { get; set; }

        public Ship(int shipHeight, int shipWidth, int maxWeight, int stackAmount, List<ShipContainer> listContainer)
        {
            ShipHeight = shipHeight;
            ShipWidth = shipWidth;
            StackAmount = stackAmount;
            MaxColumns = shipWidth / 5;
            MaxRows = shipHeight / 5;
            MaxStack = 5;
            MaxWeight = maxWeight;
            ListContainer = listContainer;
            foreach (ShipContainer container in ListContainer)
            {
                CurrentWeight += container.Weight;
                container.Height = ShipHeight / MaxRows;
                container.Width = ShipHeight / MaxColumns;
            }

            ContainerAssigner.CreateGrid(this);

            AssignContainersToGrid();

            ListErrorMessages = new List<string>();

            if (!shipMeetsRequirements(this))
            {
                //yet to implement if it doesnt meet requirements
            }
        }

        public void SetColumnAmount(int columnAmount)
        {
            ColumnAmount = columnAmount;
        }

        public void SetRowAmount(int rowAmount)
        {
            RowAmount = rowAmount;
        }

        public void SetGrid(ShipContainer[,,] grid)
        {
            Grid = grid;
        }

        private bool shipMeetsRequirements(Ship ship)
        {
            bool WeightAccepted = false;
            bool StackAccepted = false;

            //Check minimal weight
            if (CurrentWeight >= (ship.MaxWeight / 2))
            {
                WeightAccepted = true;
            }
            else
            {
                ship.ListErrorMessages.Add("Schip voldoet niet aan de eis: minimaal 50% gewicht");
            }

            if (CurrentWeight < ship.MaxWeight)
            {
                WeightAccepted = true;
            }
            else
            {
                ship.ListErrorMessages.Add("Huidige gewicht is groter dan het schip gewicht");
            }

            //Check requirement check
            if (StackAmount <= MaxStack)
            {
                StackAccepted = true;
            }
            else
            {
                ship.ListErrorMessages.Add("Kan niet hoger stapelen dan 5");
            }

            if (WeightAccepted & StackAccepted == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AssignContainersToGrid()
        {
            //Dictionary contain
            //List<ShipContainer> listNormalContainers = new List<ShipContainer>();
            //List<ShipContainer> listChilledContainers = new List<ShipContainer>();
            //List<ShipContainer> listValuableContainers = new List<ShipContainer>();

            ////Sort container type
            //foreach (ShipContainer container in ListContainer)
            //{
            //    if (container.Type == ListOfTypes.Normale.ToString())
            //    {
            //        listNormalContainers.Add(new ShipContainer(container));
            //    }
            //    if (container.Type == ListOfTypes.Gekoelde.ToString())
            //    {
            //        listChilledContainers.Add(new ShipContainer(container));
            //    }
            //    if (container.Type == ListOfTypes.Waardevolle.ToString())
            //    {
            //        listValuableContainers.Add(new ShipContainer(container));
            //    } 
            //}

            ContainerAssigner.AssignChilledContainers(this);

            ContainerAssigner.AssignNormalContainers(this);

            ContainerAssigner.AssignValuableContainers(this);

        }
    
    }
}
