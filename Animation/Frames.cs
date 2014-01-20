using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EAL.Animation
{
    public class Frames
    {
        public void wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
