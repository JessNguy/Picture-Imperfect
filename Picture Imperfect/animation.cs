using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Picture_Imperfect
{
    public class animation
    {
        Bitmap[] parts;
        int place = 0;

        public animation(Bitmap[] Frames)
        {
            parts = Frames;
        }

        public Bitmap GiveNextImage()
        {
            Bitmap b = null;
            if (place < parts.Length)
            {
                b = parts[place++];
            }
            else
            {
                place = 0;
                b = parts[place++];
            }
            return b;
        }
    }
}
