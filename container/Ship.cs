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
            //Calculate column based of valuable containers
            if      (containerTypeCount["Waardevolle"] > 0)
            {
                if (containerTypeCount["Gekoelde"] < StackAmount)
                {
                    if (containerTypeCount["Waardevolle"] < ship.MaxColumns)
                    {
                        RowAmount = containerTypeCount["Waardevolle"];
                    }
                    else
                    {
                        ListErrorMessages.Add("Te veel waardevolle containers, verhoog het hoogte of verlaag het aantal waardevolle containers");
                    }
                }
            }
            //Calculate column based of chilled containers
            if (containerTypeCount["Gekoelde"] > StackAmount)
            {
                if (Math.Ceiling((double)containerTypeCount["Gekoelde"] / StackAmount) > 1)
                {
                    ColumnAmount = Convert.ToInt32(Math.Ceiling((double)containerTypeCount["Gekoelde"] / StackAmount));
                }
                else
                {
                    ColumnAmount = Convert.ToInt32(containerTypeCount["Gekoelde"] / StackAmount);
                }
            }

            //Calculate the amount of rows
            //for (int i = ColumnAmount*StackAmount; i < ship.MaxRows*StackAmount; i += ColumnAmount*StackAmount)
            //{
            //    if (ListContainer.Count < i)
            //    {
            //        RowAmount = i/StackAmount;
            //        break;
            //    }
            //}
            int maxRowsForValuableContainer = MaxRows;

            int totalAssignable = Convert.ToInt32(Math.Ceiling((double)containerTypeCount["Gekoelde"] / StackAmount) * (MaxRows-1));
            int maxAssignable = ColumnAmount * MaxRows;

            int totalValuableAssignable = totalAssignable + maxAssignable;

            //if (containerTypeCount["Gekoelde"] / StackAmount > 1)
            //{
            //    maxRowsForValuableContainer = MaxRows - 1;
            //}
            for (int i = StackAmount*ColumnAmount; i < MaxRows*StackAmount*ColumnAmount; i+=(StackAmount*ColumnAmount))
            {
                if (containerTypeCount["Waardevolle"] <= i & ListContainer.Count <= i)
                {
                    RowAmount = i/(StackAmount*ColumnAmount);
                    break;
                }
            }
            //for (int i = 0; i < maxRowsForValuableContainer*ColumnAmount; i++)
            //{
            //    if (containerTypeCount["Waardevolle"] <= i)
            //    {
            //        RowAmount = i;
            //        break;
            //    }
            //}

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

            //0,naast getal valuable container, niet 0 stack 
            //HIERAAN WERKEN

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
                        for (int r = 0; r < RowAmount; r++)
                        {
                            for (int s = 0; s < StackAmount; s++)
                            {
                                if (c < ColumnAmount & r < RowAmount & s < StackAmount & container.Assigned == false)
                                {
                                    if (grid[c, r, s] == null)
                                    {
                                        //Check in current stack if there is a valuable container in it, if it is skip to next row
                                        if (c < ColumnAmount & r < RowAmount & s < StackAmount & container.Assigned == false)
                                        {
                                            for (int i = 0; i < StackAmount; i++)
                                            {
                                                if (i > 0 & grid[c, r, i] != null)
                                                {
                                                    if (grid[c, r, i].Type == Container.ListOfTypes[2])
                                                    {
                                                        c = Int32.MaxValue - ColumnAmount;
                                                        r = Int32.MaxValue - RowAmount;
                                                        s = Int32.MaxValue - StackAmount;
                                                        //r++;
                                                        break;
                                                    }
                                                }
                                            }
                                        }

                                        //Check in the previous row if there is a valuable container in stack 0, if it is skip to next row
                                        if (c < ColumnAmount & r < RowAmount & s < StackAmount & container.Assigned == false)
                                        {
                                            if (r > 0 & grid[c, r - 1, 0] != null)
                                            {
                                                if (grid[c, r - 1, 0].Type == Container.ListOfTypes[2])
                                                {
                                                    c = Int32.MaxValue - ColumnAmount;
                                                    r = Int32.MaxValue - RowAmount;
                                                    s = Int32.MaxValue - StackAmount;
                                                    //r++;
                                                    break;
                                                }
                                            }
                                        }

                                        //Check in the previous row if there is a valuable container in stack > 0, if it is skip to next column
                                        //if (c < ColumnAmount & r < RowAmount & s < StackAmount & container.Assigned == false)
                                        //{
                                        //    if (s > 0 & r > 0)
                                        //    {
                                        //        if (grid[c, r - 1, 0] != null)
                                        //        {
                                        //            if (grid[c, r - 1, 0].Type == Container.ListOfTypes[2])
                                        //            {
                                                        //c = Int32.MaxValue - ColumnAmount;
                                                        //r = Int32.MaxValue - RowAmount;
                                                        //s = Int32.MaxValue - StackAmount;
                                        //                c++;
                                        //                break;
                                        //            }
                                        //        }
                                        //    }
                                        //}

                                        if (c < ColumnAmount & r < RowAmount & s < StackAmount & container.Assigned == false)
                                        {
                                            grid[c, r, s] = container;
                                            container.Assigned = true;
                                            c = Int32.MaxValue - ColumnAmount;
                                            r = Int32.MaxValue - RowAmount;
                                            s = Int32.MaxValue - StackAmount;
                                            break;
                                        }

                                        //if (c < ColumnAmount | r < RowAmount | s < StackAmount)
                                        //{
                                        //    if (s == 0)
                                        //    {
                                        //        grid[c, r, s] = container;
                                        //        container.Assigned = true;
                                        //        c = Int32.MaxValue - ColumnAmount;
                                        //        r = Int32.MaxValue - RowAmount;
                                        //        s = Int32.MaxValue - StackAmount;
                                        //        break;
                                        //    }
                                        //}

                                        //if (c < ColumnAmount | r < RowAmount | s < StackAmount)
                                        //{
                                        //    if (grid[c, r, s - 1] != null)
                                        //    {
                                        //        if (grid[c, r, s - 1].Type != Container.ListOfTypes[2])
                                        //        {
                                        //            grid[c, r, s] = container;
                                        //            container.Assigned = true;
                                        //            c = Int32.MaxValue - ColumnAmount;
                                        //            r = Int32.MaxValue - RowAmount;
                                        //            s = Int32.MaxValue - StackAmount;
                                        //            break;
                                        //        }

                                        //    }
                                        //}
                                    }
                                }
                            }
                        }
                    }

                    if (container.Assigned == false)
                    {
                        container.ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        //ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }

        }
    }
}
