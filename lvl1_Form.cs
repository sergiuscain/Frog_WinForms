using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog_WinForms
{
    public partial class lvl1_Form : Form
    {
        public lvl1_Form()
        {
            InitializeComponent();
        }

        private void frog_Click(object sender, EventArgs e)
        {
            SwapFrog((PictureBox)sender);
        }

        private void SwapFrog(PictureBox frog)
        {
            frog.Dispose();
        }
    }
}
