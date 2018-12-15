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

            Grid = CreateGrid(this);
            AssignContainersToGrid(Grid);

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

        private Container[,] CreateGrid(Ship ship)
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
                for (int i = 5; i < ship.MaxColumns; i += 5)
                {
                    if (containerTypeCount["Gekoelde"] < i)
                    {
                        ColumnAmount = i / 2;
                        break;
                    }
                }
            }

            //Calculate the amount of rows
            for (int i = ColumnAmount*5; i < ship.MaxRows*5; i += ColumnAmount*5 )
            {
                if (ListContainer.Count < i)
                {
                    RowAmount = (i/2)/5;
                    break;
                }
            }

            return new Container[ColumnAmount, RowAmount];
        }

        public void AssignContainersToGrid(Container[,] grid)
        {
            //Assign the chilled containers
            foreach (Container container in ListContainer)
            {
                if (container.Type == Container.ListOfTypes[1])
                {
                    //c = column num
                    for (int c = 0; c < grid.GetLength(1); c++)
                    {
                        //r = row num
                        for (int r = 0; r < grid.GetLength(0); r++)
                        {
                            if (grid[c,r] == null)
                            {
                                grid[c, r] = container;
                                break;
                            }
                        }
                    }
                }
            }

            //Assign the valuable containers

            //Assign the normal containers
        }
    }
}
