﻿using System;
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
    public partial class CopyScreen : UserControl
    {
        public CopyScreen()
        {
            InitializeComponent();

           // Form f = this.FindForm();
           //// f.Controls.Remove(this);

           // GameScreen gs = new GameScreen();
           // f.Controls.Add(gs);

            pictureBox3.Parent = pictureBox1;
        }
    }
}
