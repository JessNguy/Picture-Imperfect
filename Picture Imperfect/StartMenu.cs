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
        public StartMenu()
        {
            InitializeComponent();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CopyScreen cs = new CopyScreen();
            f.Controls.Add(cs);
        }
    }
}
