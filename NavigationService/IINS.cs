using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationService
{
    public interface IINS
    {
        double Roll { get; set; }
        double Pitch { get; set; }
        double Yaw { get; set; }
    }
}