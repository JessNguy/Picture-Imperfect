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


        public static Image[] body;
        int partNum;
        int shirt;
        int symbol;
        int mouth;
        int head;
        Random ranNum = new Random();
        
     
        public CopyScreen()
        {
            InitializeComponent();

            partNum = ranNum.Next(1, 4);

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
            
            //flash
            if(partNum == 1)
            {
                shirt = 2;
                symbol = 3;
                head = 0;
                mouth = 1;
                e.Graphics.DrawImage(body[shirt], 0, 0, 800, 750); // shirt
                e.Graphics.DrawImage(body[symbol], 0, 0, 800, 750); // symbol
                e.Graphics.DrawImage(body[head], 0, 0, 800, 750); // head
                e.Graphics.DrawImage(body[mouth], 0, 0, 800, 750); // mouth 
            }
            //superman
            if (partNum == 2)
            {
                shirt = 6;
                symbol = 7;
                head = 4;
                mouth = 5;
                e.Graphics.DrawImage(body[shirt], 0, 0, 800, 750); // shirt
                e.Graphics.DrawImage(body[symbol], 0, 0, 800, 750); // symbol
                e.Graphics.DrawImage(body[head], 0, 0, 800, 750); // head
                e.Graphics.DrawImage(body[mouth], 0, 0, 800, 750); // mouth 
            }

            //flash
            if (partNum == 3)
            {
                shirt = 10;
                symbol = 11;
                head = 8;
                mouth = 9;
                e.Graphics.DrawImage(body[shirt], 0, 0, 800, 750); // shirt
                e.Graphics.DrawImage(body[symbol], 0, 0, 800, 750); // symbol
                e.Graphics.DrawImage(body[head], 0, 0, 800, 750); // head
                e.Graphics.DrawImage(body[mouth], 0, 0, 800, 750); // mouth 
            }

        }

        private void CopyScreen_Load(object sender, EventArgs e)
        {
            for (int x = 0; x <= 1; x++)
            {
                Refresh();
                Thread.Sleep(1000);

                labelCount.Text = Convert.ToString(x);
            }

            if (labelCount.Text == "1")
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
