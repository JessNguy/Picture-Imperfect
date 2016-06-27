using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picture_Imperfect
{
    public partial class GameScreen : UserControl
    {
        //labelcountdown, sleep
        //isnt able to stop the animation
        //lock in body part
        //work on the next body part 
        //copyscreen needs to have random parts selected put into fullybody class
        //compare to copyscreen
        //work on player 2

        
        Graphics g;
        Graphics hG;
        Bitmap btm;
        animation animateHead;
        animation animateMouth;
        animation animateShirt;
        animation animateSymbol;

        public GameScreen()
        {
            InitializeComponent();           
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Base, 24, 0, 372, 339);
            //have a buttonclickcount so that it can skip that animations to the next set

            
                //count down from 3, text in the middle of the screen
                //when count == 0
                //make it loop the head image in the list . 0,4,8
                //lock the int of the chosen head to the string                         
                
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            for (int x = 3; x >= 0; x--)
            {
                labelCountDown.Text = Convert.ToString(x);
                Refresh();
                Thread.Sleep(100);               
            }
            if (labelCountDown.Text == "0")
            {
                timer1.Start();
            }

            g = this.CreateGraphics();
            btm = new Bitmap (372, 339);                   
            hG = Graphics.FromImage(btm);

           animateHead = new animation(new Bitmap[] {Properties.Resources.Flash_Head, Properties.Resources.SHead_Size,
                Properties.Resources.Captain_America_Head});

           animateMouth = new animation(new Bitmap[] {Properties.Resources.Flash_Mouth, Properties.Resources.SMouth_Size,
                Properties.Resources.Captain_America_Mouth});

           animateShirt = new animation(new Bitmap[] {Properties.Resources.Flash_Shirt, Properties.Resources.S_Shirt_size,
                Properties.Resources.Captain_America_Shirt});

           animateSymbol = new animation(new Bitmap[] {Properties.Resources.Flash_Symbol, Properties.Resources.Symbol_Size,
                Properties.Resources.Captain_America_Symbol});             
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            hG.DrawImage(animateHead.GiveNextImage(),20,23,372,339);
            g.DrawImage(btm, Point.Empty);            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            hG.DrawImage(animateMouth.GiveNextImage(), 20, 23, 372, 339);
            g.DrawImage(btm, Point.Empty);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Focus();
            switch (e.KeyCode)
            {
                case Keys.B:
                    timer1.Stop();                                      
                    timer2.Start();         
                    break;
                case Keys.C:
                    
                    break;
                default:
                    break;
            }
        }

       

       
    }
}
