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
        public Container[,,] Grid { get; private set; }
        public List<Container> ListContainer { get; private set; }

        public int MaxColumns { get; private set; }
        public int MaxRows{ get; private set; }
        public int MaxStack { get; private set; }

        //checking related
        public List<string> ListErrorMessages { get; set; }

        public Ship(int shipHeight, int shipWidth, int maxWeight, int stackAmount ,List<Container> listContainer)
        {
            ShipHeight = shipHeight;
            ShipWidth = shipWidth;
            StackAmount = stackAmount;
            MaxColumns = shipWidth / 5;
            MaxRows = shipHeight / 5;
            MaxStack = 5;
            MaxWeight = maxWeight;
            ListContainer = listContainer;
            foreach (Container container in ListContainer)
            {
                CurrentWeight += container.Height;
            }
            ListContainer = listContainer;

            Grid = CreateGrid(this);
            AssignContainersToGrid(Grid);

            ListErrorMessages = new List<string>();

            if (!shipMeetsRequirements(this))
            {

            }
        }

        private bool shipMeetsRequirements(Ship ship)
        {
            bool WeightAccepted = false;
            bool StackAccepted = false;

            if (CurrentWeight >= (ship.MaxWeight/2))
            {
                WeightAccepted = true;
            }
            else
            {
                ship.ListErrorMessages.Add("Schip voldoet niet aan de eis: minimaal 50% gewicht");
            }

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

        private Container[,,] CreateGrid(Ship ship)
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
            //Calculate the amount of column
            if(containerTypeCount["Waardevolle"]/2 >= containerTypeCount["Gekoelde"]/5)
            {
                for (int i = 2; i < ship.MaxColumns; i += 2)
                {
                    if (containerTypeCount["Waardevolle"] < i)
                    {
                        ColumnAmount = i / 2;
                        break;
                    }
                }
            }
            else
            {
                for (int i = StackAmount; i < ship.MaxColumns; i += StackAmount)
                {
                    if (containerTypeCount["Gekoelde"] < i)
                    {
                        ColumnAmount = i / 2;
                        break;
                    }
                }
            }

            //Calculate the amount of rows
            for (int i = ColumnAmount*StackAmount; i < ship.MaxRows*StackAmount; i += ColumnAmount*StackAmount)
            {
                if (ListContainer.Count < i)
                {
                    RowAmount = i/StackAmount;
                    break;
                }
            }

            return new Container[ColumnAmount, RowAmount, StackAmount];
        }

        public void AssignContainersToGrid(Container[,,] grid)
        {
            //Dictionary contain
            List<ShipContainer> listNormalContainers = new List<ShipContainer>();
            List<ShipContainer> listChilledContainers = new List<ShipContainer>();
            List<ShipContainer> listValuableContainers = new List<ShipContainer>();

            //Sort container type
            foreach (Container container in ListContainer)
            {
                if (container.Type == Container.ListOfTypes[0])
                {
                    listNormalContainers.Add(new ShipContainer(container));
                }
                if (container.Type == Container.ListOfTypes[1])
                {
                    listChilledContainers.Add(new ShipContainer(container));
                }
                if (container.Type == Container.ListOfTypes[2])
                {
                    listValuableContainers.Add(new ShipContainer(container));
                }
            }

            //Assign the chilled containers
            foreach (ShipContainer container in listChilledContainers)
            {
                if (container.Type == Container.ListOfTypes[1] & container.Assigned == false)
                {
                    //c = column position
                    //r = row position
                    //s = stack position

                    int r = 0;

                    for (int c = 0; c < ColumnAmount; c++)
                    {
                        for (int s = 0; s < StackAmount; s++)
                        {
                            if (grid[c, r, s] == null)
                            {
                                grid[c, r, s] = container;
                                container.Assigned = true;
                                c = Int32.MaxValue - ColumnAmount;
                                r = Int32.MaxValue - RowAmount;
                                s = Int32.MaxValue - StackAmount;
                                break;
                            }
                        }
                    }
                    if (container.Assigned == false)
                    {
                        container.ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }

            //Assign the normal containers 
            for (int i = 0; i < listNormalContainers.Count; i++)
            {
                if (listNormalContainers[i].Type == Container.ListOfTypes[0] & listNormalContainers[i].Assigned == false)
                {
                    int counterValuableContainer = 0;

                    //c = column position
                    //r = row position
                    //s = stack position

                    for (int c = 0; c < ColumnAmount; c++)
                    {
                        for (int r = 0; r < RowAmount; r++)
                        {
                            for (int s = 0; s < StackAmount; s++)
                            {
                                //if (r == 0 & grid[c, r, s] == null | r == RowAmount - 1 & grid[c, r, s] == null)
                                //{
                                //    if (s == StackAmount - 1 | i == listNormalContainers.Count - 1)
                                //    {
                                //        foreach (ShipContainer valuableContainer in listValuableContainers)
                                //        {
                                //            if (valuableContainer.Assigned == false)
                                //            {
                                //                grid[c, r, s] = valuableContainer;
                                //                valuableContainer.Assigned = true;
                                //                break;
                                //            }
                                //        }
                                //    }
                                //}
                                if (grid[c, r, s] == null)
                                {
                                    if (s == StackAmount-1 & listValuableContainers.Count > counterValuableContainer)
                                    {
                                        counterValuableContainer++;
                                        break;
                                    }
                                    else
                                    {
                                        grid[c, r, s] = listNormalContainers[i];
                                        listNormalContainers[i].Assigned = true;
                                        c = Int32.MaxValue - ColumnAmount;
                                        r = Int32.MaxValue - RowAmount;
                                        s = Int32.MaxValue - StackAmount;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (listNormalContainers[i].Assigned == false)
                    {
                        listNormalContainers[i].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        ListContainer[ListContainer.IndexOf(listNormalContainers[i])].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
                
            }

            //Assign the valuable containers
            foreach (ShipContainer container in listValuableContainers)
            {
                if (container.Type == Container.ListOfTypes[2] & container.Assigned == false)
                {
                    //c = column position
                    //r = row position
                    //s = stack position

                    for (int c = 0; c < ColumnAmount; c++)
                    {
                        for (int r = 0; r < RowAmount; r ++)
                        {
                            for (int s = 0; s < StackAmount; s++)
                            {
                                if (grid[c, r, s] == null)
                                {
                                    if (s == 0)
                                    {
                                        grid[c, r, s] = container;
                                        container.Assigned = true;
                                        c = Int32.MaxValue - ColumnAmount;
                                        r = Int32.MaxValue - RowAmount;
                                        s = Int32.MaxValue - StackAmount;
                                        break;
                                    }
                                    if (grid[c, r, s - 1] != null)
                                    {
                                        if (grid[c, r, s - 1].Type != Container.ListOfTypes[2])
                                        {
                                            grid[c, r, s] = container;
                                            container.Assigned = true;
                                            c = Int32.MaxValue - ColumnAmount;
                                            r = Int32.MaxValue - RowAmount;
                                            s = Int32.MaxValue - StackAmount;
                                            break;
                                        }

                                    }
                                }
                            }
                        }
                    }
                    if (container.Assigned == false)
                    {
                        container.ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }

        }
    }
}
