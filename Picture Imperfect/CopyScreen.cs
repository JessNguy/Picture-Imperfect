using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Picture_Imperfect
{
    public partial class CopyScreen : UserControl
    {
        public CopyScreen()
        {
            InitializeComponent();

            pictureBoxMouth.Parent = pictureBoxHead;
            pictureBoxHead.Parent = pictureBoxShirt;
            pictureBoxSymbol.Parent = pictureBoxHead;

           

            Refresh();
            //Thread.Sleep(1000);

            //Form f = this.FindForm();
            //GameScreen gs = new GameScreen();

            //f.Controls.Add(gs);
            //gs.BringToFront();
            //f.Controls.Remove(this);


        }

        private void pictureBoxSymbol_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CopyScreen_Load(object sender, EventArgs e)
        {

        }

        private void CopyScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Flash_Head, 0, 0, 800, 750);
            e.Graphics.DrawImage(Properties.Resources.Flash_Mouth, 0, 0, 800, 750);
        }
    }
}
