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
            Container container = new Container(10,10,0,31);

            List<Container> list = new List<Container>();

            list.Add(container);
        }
    }
}
