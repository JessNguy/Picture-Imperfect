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
    public partial class StartMenu : UserControl
    {
        bool buttonPress = false;

        public StartMenu()
        {
            InitializeComponent();
            //player 1 
            //b,n,m,space
            //player 2
            //c,v,x,z
            //blue, yellow, red, green
                  
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonPress == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                CopyScreen cs = new CopyScreen();
                f.Controls.Add(cs);
            }
        }

        private void StartMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    pictureBoxPlayer1.Image = Properties.Resources.Gobutton;
                    buttonPress = true;
                    break;

                case Keys.Z:
                    pictureBoxPlayer2.Image = Properties.Resources.Gobutton;
                    buttonPress = true;
                    break;
                default:
                    break;
            }
        }
    }
}
