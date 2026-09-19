using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWargame
{
     class City
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int coordinates { get; set; }

        public bool ownedByPlayer { get; set; } = false;
        public City(string name, int strength, int coordinates) 
        {
            this.name = name;
            this.strength = strength;
            this.coordinates = coordinates;
        }


    }
}
