using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationService
{
    public interface INavigationService
    {
        IINS IINS { get; set; }
        IGPS IGPS { get; set; }
    }
}