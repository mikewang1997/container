using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Container
    {
        //In tons
        public int Height { get; set; }
        public int Width { get; set; }
        public int Type { get; set; }
        public int Weight { get; set; }

        public Container(int height, int width, int type, int weight)
        {
            Height = height;
            Width = width;
            Type = type;

            weight += 4;
            if (!(weight > 30))
            {
                Weight = weight;
            }
            else
            {
                //throw new System.ArgumentException("Weight is over 30ton", "Weight");
                System.Windows.Forms.MessageBox.Show("Weight is over 30 ton!");
            }
        }
    }
}
