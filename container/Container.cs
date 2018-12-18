using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    public enum ListOfTypes
    {
        Normale = 0,
        Gekoelde = 1,
        Waardevolle = 2
    }
    abstract class Container
    {
        //In tons
        public int Height { get; set; }
        public int Width { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        //public static Dictionary<int, string> ListOfTypes = new Dictionary<int, string>
        //{
        //    { 0, "Normale" },
        //    { 1, "Gekoelde" },
        //    { 2, "Waardevolle" }
        //};

        //checking related
        public List<string> ListErrorMessages { get; set; }

        public Container(string type, int weight)
        {
            foreach(var t in Enum.GetNames(typeof(ListOfTypes)))
            {
                if (type == t)
                {
                    Type = t;
                    break;
                }
            }
            ListErrorMessages = new List<string>();
            Weight = weight + 4;

            if (!containerMeetsRequirements(this))
            {
                Height = 0;
                Width = 0;
                Type = "null";
                Weight = 0;
            }

        }

        private bool containerMeetsRequirements(Container container)
        {
            if (!(container.Weight > 30))
            {
                return true;
            }
            else
            {
                container.ListErrorMessages.Add("De container weegt over 30 ton!");
                return false;
            }
        }


    }
}
