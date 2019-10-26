using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationService
{
    public class NavigationService : INavigationService
    {
        public IINS IINS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGPS IGPS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}