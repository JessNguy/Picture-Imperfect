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
        bool playerLock = false;
        bool startClick = false;

        public StartMenu()
        {
            InitializeComponent();
            //player 1 
            //b,n,m,space
            //player 2
            //c,v,x,z
            //blue, yellow, red, green

        }

        private void StartMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.N:
                    pictureBoxPlayer1.Image = Properties.Resources.Gobutton;
                    playerLock = true;
                    break;
                case Keys.V:
                    pictureBoxPlayer2.Image = Properties.Resources.Gobutton;
                    playerLock = true;
                    break;
                case Keys.B:
                    labelStartInfo.ForeColor = Color.Blue;
                    labelStartInfo.Text = 
                    "Hit the circle to stop the correct" + "\n"
                    + "parts as they appear. Try to"
                    + "\n" + "re - create the original picture.";
                    break;
                case Keys.C:
                    labelStartInfo.ForeColor = Color.Blue;
                    labelStartInfo.Text =
                    "Hit the circle to stop the correct" + "\n"
                    + "parts as they appear. Try to"
                    + "\n" +"re - create the original picture.";
                    break;
                case Keys.Space:
                    labelStartInfo.ForeColor = Color.Green;
                    labelStartInfo.Text = "Hit the Blue Button.";
                    break;
                case Keys.Z:
                    labelStartInfo.ForeColor = Color.Green;
                    labelStartInfo.Text = "Hit the Blue Button.";
                    break;
                case Keys.M:
                    startClick = true;

                    if (playerLock == true && startClick == true)
                    {
                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        CopyScreen cs = new CopyScreen();
                        f.Controls.Add(cs);
                    }
                    break;
                case Keys.X:
                    startClick = true;

                    if (playerLock == true && startClick == true)
                    {
                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        CopyScreen cs = new CopyScreen();
                        f.Controls.Add(cs);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
