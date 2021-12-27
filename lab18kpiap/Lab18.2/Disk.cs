using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._2
{
    class Disk
    {
        public string Name { get; set; }
        public string Sinker { get; set; }
        public Disk(string name, string sinker)
        {
            Name = name;
            Sinker = sinker;
        }
        public Disk() { }
    }
}
