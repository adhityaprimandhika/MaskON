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
    public partial class DonateMask : Form
    {
        public DonateMask()
        {
            InitializeComponent();
        }

        //button Submit
        private void btnSubmit_Click(object sender, EventArgs e)
            // database Donator
        {
            if (boxMask.Text == "" || textJumlah.Text == "" || boxDropoff.Text == "")
            {
                MessageBox.Show("Please fill all the boxes.");
            }
            else
            {
                //database reciever
                new Ending().Show();
                this.Hide();
            }
        }

        //button Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Tipe().Show();
            this.Hide();
        }

        // bagian bawah ini ga perlu diisi sepertinya, tapi gabisa dihapus //

        //bahan database untuk jenis donasi masker
        private void boxMask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //bahan database untuk jumlah donasi masker
        private void textJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        //bahan database untuk lokasi pemberian donasi
        private void boxDropoff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
