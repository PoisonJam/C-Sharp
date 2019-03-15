using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (this.rdo1.Checked)
            {
                MessageBox.Show(this.txtData.Text);
                this.Close();
            }
            if (this.rdo2.Checked)
            {
                MessageBox.Show(this.cboData.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("ANGGGGGRYY SMASSHHHHH");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboData.SelectedIndex = 2;
        }

        private void bto2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);
        }
    }
}
