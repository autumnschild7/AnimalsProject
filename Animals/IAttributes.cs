using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface IAttributes
    {
        string Name { get; set; }
        string Size { get; set; }
        string Noise { get; set; }
        string NumberOfFeet { get; set; }
    }
}
