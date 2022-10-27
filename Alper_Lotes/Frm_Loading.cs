using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Alper_Lotes
{
    public partial class Frm_Loading : Form
    {
        public Frm_Loading()
        {
            InitializeComponent();
        }

        private void Frm_Loading_Load(object sender, EventArgs e)
        {
            timer_loading.Enabled = true;

        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                pgr_loading.Value += 20;
                Thread.Sleep(1000);
            }
            timer_loading.Enabled = false;
        }
    }
}
