using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Thing
    {
        public string Name
        {
            get;
        }
        public string Description
        {
            get;
        }
        public Image Icon
        {
            get;
        }
        public Thing(string name, string desc, Image icon)
        {
            Name = name;
            Description = desc;
            Icon = icon;
        }
    }
}
