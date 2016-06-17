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
            e.Graphics.DrawImage(CopyScreen.body[6],20, 16, 372, 339); //Flash shirt
            e.Graphics.DrawImage(CopyScreen.body[7], 20, 16, 372, 339); //Flash symbol
            e.Graphics.DrawImage(CopyScreen.body[4], 20, 16, 372, 339); //Flash head
            e.Graphics.DrawImage(CopyScreen.body[5], 20, 16, 372, 339); //Flash mouth
        }
    }
}
