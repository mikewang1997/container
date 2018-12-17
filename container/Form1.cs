using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace container
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            foreach (var item in container.Container.ListOfTypes)
            {
                comboBoxContainerType.Items.Add(item.Value);
            }

            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Waardevolle", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Gekoelde", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));
            //listContainers.Add(new ShipContainer(new Container(10, 10, "Normale", 1)));




            //if (container.ListErrorMessages.Count == 0)
            //{

            //}
            //else
            //{
            //    foreach (var item in collection)
            //    {

            //    }
            //    MessageBox.Show();
            //}

        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            List<ShipContainer> listContainers = listBoxContainer.Items.Cast<ShipContainer>().ToList();

            Ship eenSchip = new Ship(Convert.ToInt32(txtBoxHeight.Text), Convert.ToInt32(txtBoxWidth.Text), 
                                    Convert.ToInt32(txtBoxShipWeight.Text), Convert.ToInt32(txtBoxStack.Text), listContainers);


            int breakCounter = 0;
            foreach (var container in eenSchip.Grid)
            {
                if (eenSchip.ListErrorMessages.Count <= 0)
                {
                    if (container != null)
                    {
                        if (container.ListErrorMessages.Count <= 0)
                        {
                            dataGridViewShip.Rows.Add(container.Position.Column + 1, container.Position.Row + 1, container.Position.Stack + 1, container.Type, container.Weight);
                            if (container.Position.Stack + 1 == 5)
                            {
                                dataGridViewShip.Rows.Add();
                            }
                        }
                    }
                    else
                    {
                        breakCounter++;
                    }
                    if (breakCounter > 0)
                    {
                        dataGridViewShip.Rows.Add();
                        breakCounter = 0;
                    }
                }
                else
                {
                    foreach (string message in eenSchip.ListErrorMessages)
                    {
                        MessageBox.Show(message);
                    }
                    break;

                }

            }
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            int countWeight = 0;
            int countNormal = 0;
            int countChilled = 0;
            int countValuable = 0;
            ShipContainer con = new ShipContainer(new Container(comboBoxContainerType.SelectedItem.ToString(), Convert.ToInt32(txtBoxContainerWeight.Text)));
            listBoxContainer.Items.Add(con);
            foreach (ShipContainer c in listBoxContainer.Items)
            {
                if (c.Type == container.Container.ListOfTypes[0])
                {
                    countNormal += 1;
                }
                if (c.Type == container.Container.ListOfTypes[1])
                {
                    countChilled += 1;
                }
                if (c.Type == container.Container.ListOfTypes[2])
                {
                    countValuable += 1;
                }
                countWeight += c.Weight;
            }
            lblTotalWeight.Text = "Total weight:" + countWeight;
            lblNormal.Text = "Total normal:" + countNormal;
            lblChilled.Text = "Total chilled:" + countChilled; 
            lblValuable.Text = "Total valuable:" + countValuable;
        }
    }
}
