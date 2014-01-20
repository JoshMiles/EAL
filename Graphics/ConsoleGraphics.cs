using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAL.Graphics
{
    public class ConsoleGraphics
    {
        public void TypeWriter(string text, int delay = 25)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(delay);
            }
        }


    }
}
