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
    public partial class UserControl2 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            List<LopHoc> dslh = db.LopHocs.ToList();
            dataGridView1.DataSource = dslh;
        }
    }
}
