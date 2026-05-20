using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Sinh_Viên
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);
        }
    }
}
