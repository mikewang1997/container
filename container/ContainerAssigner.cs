using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    static class ContainerAssigner
    {
        static public void AssignNormalContainers(Ship ship)
        {
            foreach (ShipContainer container in ship.ListContainer)
            {
                if (container.Type == ListOfTypes.Normale.ToString() & container.Assigned == false)
                {
                    //c = column position
                    //r = row position
                    //s = stack position
                    int maxStack = ship.ColumnAmount * ship.StackAmount;

                    for (int s = 0; s < ship.StackAmount; s++)
                    {
                        for (int r = 0; r < ship.RowAmount; r++)
                        {
                            for (int c = 0; c < ship.ColumnAmount; c++)
                            {
                                if (c < ship.ColumnAmount & r < ship.RowAmount & s < ship.StackAmount & container.Assigned == false)
                                {
                                    if (ship.Grid[c, r, s] == null)
                                    {
                                        ship.Grid[c, r, s] = container;
                                        container.Position.Column = c;
                                        container.Position.Row = r;
                                        container.Position.Stack = s;
                                        container.Assigned = true;
                                        c = Int32.MaxValue - ship.ColumnAmount;
                                        r = Int32.MaxValue - ship.RowAmount;
                                        s = Int32.MaxValue - ship.StackAmount;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (container.Assigned == false)
                    {
                        //ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        container.ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }
        }
        static public void AssignValuableContainers(Ship ship)
        {
            //Assign the valuable containers
            foreach (ShipContainer container in ship.ListContainer)
            {
                if (container.Type == ListOfTypes.Waardevolle.ToString() & container.Assigned == false)
                {
                    //c = column position
                    //r = row position
                    //s = stack position

                    for (int c = 0; c < ship.ColumnAmount; c++)
                    {
                        for (int r = 0; r < ship.RowAmount; r++)
                        {
                            for (int s = 0; s < ship.StackAmount; s++)
                            {
                                if (c < ship.ColumnAmount & r < ship.RowAmount & s < ship.StackAmount & container.Assigned == false)
                                {
                                    if (ship.Grid[c, r, s] == null)
                                    {
                                        //Check in current stack if there is a valuable container in it, if it is skip to next row
                                        if (c < ship.ColumnAmount & r < ship.RowAmount & s < ship.StackAmount & container.Assigned == false)
                                        {
                                            for (int i = 0; i < ship.StackAmount; i++)
                                            {
                                                if (i > 0 & ship.Grid[c, r, i] != null)
                                                {
                                                    if (ship.Grid[c, r, i].Type == ListOfTypes.Waardevolle.ToString())
                                                    {
                                                        //c = Int32.MaxValue - ColumnAmount;
                                                        //r = Int32.MaxValue - RowAmount;
                                                        s = Int32.MaxValue - ship.StackAmount;
                                                        //r++;
                                                        break;
                                                    }
                                                }
                                            }
                                        }

                                        if (c < ship.ColumnAmount & r < ship.RowAmount & s < ship.StackAmount & container.Assigned == false)
                                        {
                                            ship.Grid[c, r, s] = container;
                                            container.Position.Column = c;
                                            container.Position.Row = r;
                                            container.Position.Stack = s;
                                            container.Assigned = true;
                                            c = Int32.MaxValue - ship.ColumnAmount;
                                            r = Int32.MaxValue - ship.RowAmount;
                                            s = Int32.MaxValue - ship.StackAmount;
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
                        //ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }
        }

        public static void AssignChilledContainers(Ship ship)
        {
            //Assign the chilled containers 
            foreach (ShipContainer container in ship.ListContainer)
            {
                if (container.Type == ListOfTypes.Gekoelde.ToString() & container.Assigned == false)
                {
                    //c = column position
                    //r = row position
                    //s = stack position

                    int r = 0;

                    for (int c = 0; c < ship.ColumnAmount; c++)
                    {
                        for (int s = 0; s < ship.StackAmount; s++)
                        {
                            if (ship.Grid[c, r, s] == null)
                            {
                                ship.Grid[c, r, s] = container;
                                container.Position.Column = c;
                                container.Position.Row = r;
                                container.Position.Stack = s;
                                container.Assigned = true;
                                c = Int32.MaxValue - ship.ColumnAmount;
                                r = Int32.MaxValue - ship.RowAmount;
                                s = Int32.MaxValue - ship.StackAmount;
                                break;
                            }
                        }
                    }
                    if (container.Assigned == false)
                    {
                        //ListContainer[ListContainer.IndexOf(container)].ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                        container.ListErrorMessages.Add("Kon de container geen plek geven in het schip, verhoog het grootte van het schip");
                    }
                }
            }
        }
    }
}
