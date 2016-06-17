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
        //make the copy screen go to game screen
        //make end game user control
        //make game go through the order and pause and lock in keypress
        //high score XML file

        Image[] body;

        public CopyScreen()
        {
            InitializeComponent();

            body = new Image[20];
            body[0] = Properties.Resources.Flash_Head;
            body[1] = Properties.Resources.Flash_Mouth;
            body[2] = Properties.Resources.Flash_Shirt;
            body[3] = Properties.Resources.Flash_Symbol;
            body[4] = Properties.Resources.SHead_Size;
            body[5] = Properties.Resources.SMouth_Size;
            body[6] = Properties.Resources.S_Shirt_size;
            body[7] = Properties.Resources.Symbol_Size;
            body[8] = Properties.Resources.Captain_America_Head;
            body[9] = Properties.Resources.Captain_America_Mouth;
            body[10] = Properties.Resources.Captain_America_Shirt;
            body[11] = Properties.Resources.Captain_America_Symbol;

        }


        private void CopyScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(body[6], 0, 0, 800, 750); //Flash shirt
            e.Graphics.DrawImage(body[7], 0, 0, 800, 750); //Flash symbol
            e.Graphics.DrawImage(body[4], 0, 0, 800, 750); //Flash head
            e.Graphics.DrawImage(body[5], 0, 0, 800, 750); //Flash mouth     

         }

        private void CopyScreen_Load(object sender, EventArgs e)
        {
            for (int x = 0; x <= 3; x++)
            {
                Refresh();
                Thread.Sleep(1000);

                labelCount.Text = Convert.ToString(x);
            }

            if (labelCount.Text == "3")
            {
                Form f = this.FindForm();
                GameScreen gs = new GameScreen();

                f.Controls.Add(gs);
                gs.BringToFront();
                f.Controls.Remove(this);
            }


        }
    }
}
