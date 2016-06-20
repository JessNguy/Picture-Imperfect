using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Imperfect
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
           
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Base, 30, 0, 372, 339);

            if ()
            {
            }
            //e.Graphics.DrawImage(CopyScreen.body[6], 20, 23, 372, 339); //Shirt
            //e.Graphics.DrawImage(CopyScreen.body[11], 20, 23, 372, 339); //Symbol
            //e.Graphics.DrawImage(CopyScreen.body[0], 20, 23, 372, 339); //Head
            //e.Graphics.DrawImage(CopyScreen.body[1], 20, 23, 372, 339); //Mouth
        }
    }
}
