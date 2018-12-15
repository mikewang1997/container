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
            List<Container> listContainers = new List<Container>();

            listContainers.Add(new Container(10, 10, 0, 10));
            listContainers.Add(new Container(10, 10, 1, 10));
            listContainers.Add(new Container(10, 10, 1, 10));
            listContainers.Add(new Container(10, 10, 2, 10));
            listContainers.Add(new Container(10, 10, 0, 10));
            listContainers.Add(new Container(10, 10, 0, 10));

            Ship eenSchip = new Ship(50,50,150, listContainers);


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
    }
}
