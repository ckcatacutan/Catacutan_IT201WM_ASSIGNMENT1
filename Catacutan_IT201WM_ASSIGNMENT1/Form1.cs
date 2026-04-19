using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catacutan_IT201WM_ASSIGNMENT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearGroupBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else
                {
                    ClearGroupBox(c);
                }
            }
        }

         private void lblPrelimAssign_Click(object sender, EventArgs e)
         {

         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroupBox(groupBox1);
            ClearGroupBox(groupBox2);
            ClearGroupBox(groupBox3);
            ClearGroupBox(groupBox4);
            ClearGroupBox(groupBox5);
            ClearGroupBox(groupBox6);
            ClearGroupBox(groupBox7);
            ClearGroupBox(groupBox8);
            ClearGroupBox(groupBox9);
            ClearGroupBox(groupBox10);
            ClearGroupBox(groupBox11);
            ClearGroupBox(groupBox12);
            ClearGroupBox(groupBox13);
            ClearGroupBox(groupBox14);
            ClearGroupBox(groupBox15);
            txtPrelimGrade.Clear();
            txtMidtermGrade.Clear();
            txtFinalsGrade.Clear();
            lblFinalGrade.Text = "";
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
