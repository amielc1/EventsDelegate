using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationService
{
    public interface IGPS
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}