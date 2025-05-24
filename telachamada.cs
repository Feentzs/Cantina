using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class telachamada : Form
    {
        public telachamada()
        {
            InitializeComponent();
        }
       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
