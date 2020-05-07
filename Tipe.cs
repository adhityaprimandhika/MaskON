using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskON
{
    public partial class Tipe : Form
    {
        public Tipe()
        {
            InitializeComponent();
        }

        //button Be a Donator
        private void btnDonator_Click(object sender, EventArgs e)
        {
            new DonateMask().Show();
            this.Hide();
        }

        //button Recieve donation
        private void btnRecieve_Click(object sender, EventArgs e)
        {
            new ReceiveMask().Show();
            this.Hide();
        }
    }
}
