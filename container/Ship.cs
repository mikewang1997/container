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

            Grid = CreateGrid(this);
            AssignContainersToGrid();

            ListErrorMessages = new List<string>();

            if (!shipMeetsRequirements(this))
            {
                //yet to implement if it doesnt meet requirements
            }
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

        private ShipContainer[,,] CreateGrid(Ship ship)
        {
            //Dictionary<string, int> containerTypeCount = new Dictionary<string, int>();
            int countNormalContainers = 0;
            int countChilledContainers = 0;
            int countValuableContainers = 0;

            //Initialize the containerTypeCount
            //for (int i = 0; i < Container.ListOfTypes.Count; i++)
            //{
            //    containerTypeCount.Add(Container.ListOfTypes[i], 0);
            //}

            //Count all the containerTypeCount
            //foreach (Container container in ship.ListContainer)
            //{
            //    for (int i = 0; i < Container.ListOfTypes.Count; i++)
            //    {
            //        if (container.Type == Container.ListOfTypes[i])
            //        {
            //            containerTypeCount[Container.ListOfTypes[i]] += 1;
            //            break;
            //        }

            //        if (i > Container.ListOfTypes.Count)
            //        {
            //            throw new ArgumentException("Container type is not correct, Check container ListOfTypes", "Container Type");
            //        }
            //    }
            //}

            foreach (ShipContainer container in ship.ListContainer)
            {
                if (container.Type == ListOfTypes.Normale.ToString())
                {
                    countNormalContainers++;
                }
                if (container.Type == ListOfTypes.Gekoelde.ToString())
                {
                    countChilledContainers++;
                }
                if (container.Type == ListOfTypes.Waardevolle.ToString())
                {
                    countValuableContainers++;
                }
            }

            //Calculate column based of valuable containers
            if (countValuableContainers > 0)
            {
                if (countChilledContainers < StackAmount)
                {
                    if (countValuableContainers < ship.MaxColumns)
                    {
                        RowAmount = countValuableContainers;
                    }
                    else
                    {
                        ListErrorMessages.Add("Te veel waardevolle containers, verhoog het hoogte of verlaag het aantal waardevolle containers");
                    }
                }
            }
            //Calculate column based of chilled containers
            ////if (containerTypeCount["Gekoelde"] > StackAmount)
            ////{
            if (Math.Ceiling((double)countChilledContainers / StackAmount) <= 1)
            {
                ColumnAmount = Convert.ToInt32(Math.Ceiling((double)countChilledContainers / StackAmount));
            }
            else
            {
                ColumnAmount = Convert.ToInt32(countChilledContainers / StackAmount);
            }
            //}

            //Calculate the amount of rows
            int rowsBasedOnValuableContainers = 0; // just to initialize

            int rowsBasedOnTotalContainers = 0; // just to initialize

            if (ColumnAmount > 0)
            {
                rowsBasedOnValuableContainers = Convert.ToInt32(Math.Ceiling((double)countValuableContainers / ColumnAmount)) + (ColumnAmount / ColumnAmount);
            }

            for (int i = StackAmount * ColumnAmount; i < MaxRows * StackAmount * ColumnAmount; i += (StackAmount * ColumnAmount))
            {
                if (ListContainer.Count <= i)
                {
                    rowsBasedOnTotalContainers = i / (StackAmount * ColumnAmount);
                    break;
                }
            }

            //Pick the amount of rows who has priority
            if (rowsBasedOnValuableContainers >= rowsBasedOnTotalContainers)
            {
                RowAmount = rowsBasedOnValuableContainers;
            }
            else
            {
                RowAmount = rowsBasedOnTotalContainers;
            }

            return new ShipContainer[ColumnAmount, RowAmount, StackAmount];
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
