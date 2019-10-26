using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationService
{
    public class INS : IINS
    {
        public double Roll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Pitch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Yaw { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}