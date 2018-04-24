using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.helpers
{
    internal class LoadPicture
    {
        public static Image GetImage(string path)
        {
            Image img;
            using (var temp = Image.FromFile(path))
            {
                img = new Bitmap(temp);
            }
            return img;
        }
    }
}
