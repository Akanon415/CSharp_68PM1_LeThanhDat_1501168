using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản_Lý_Sinh_Viên
{
    public partial class UserControl2 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int currentPage = 1;
        int pageSize = 5;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            List<LopHoc> dslh = db.LopHocs.ToList();
            dataGridView1.DataSource = dslh;
        }
        public void LoadData()
        {
            var dslh = db.LopHocs
            .OrderBy(x => x.Id)
            .Skip((currentPage - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            dataGridView1.DataSource = dslh;

            int totalPages = (int)Math.Ceiling(
            (double)db.LopHocs.Count() / pageSize);

            label7.Text = $"Trang {currentPage}/{totalPages}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LopHoc lophoc = new LopHoc();
            lophoc.Id = int.Parse(textBox1.Text);
            lophoc.MaLop = textBox2.Text;
            lophoc.TenLop = textBox4.Text;
            lophoc.GhiChu = textBox5.Text;
            try
            {
                db.LopHocs.InsertOnSubmit(lophoc);
                db.SubmitChanges();
                MessageBox.Show("Them lop thanh cong.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBox1.Text);

                LopHoc lh = db.LopHocs.FirstOrDefault(x => x.Id == Id);

                if (lh != null)
                {
                    lh.MaLop = textBox2.Text;
                    lh.TenLop = textBox4.Text;
                    lh.GhiChu = textBox5.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Cap nhat thanh cong!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Khong tim thay lop hoc!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["MaLop"].Value.ToString();
                textBox4.Text = row.Cells["TenLop"].Value.ToString();
                textBox5.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban co chac chan muon xoa lop hoc nay?",
                "Xac nhan",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int Id = int.Parse(textBox1.Text);
                LopHoc lh = db.LopHocs
                                    .FirstOrDefault(x => x.Id == Id);

                if (lh != null)
                {
                    db.LopHocs.DeleteOnSubmit(lh);
                    db.SubmitChanges();
                    MessageBox.Show("Xoa thanh cong!");
                    LoadData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox3.Text.Trim();

            var ketQua = db.LopHocs
                           .Where(lh =>
                                lh.MaLop.Contains(keyword) ||
                                lh.Id.ToString().Contains(keyword) ||
                                lh.TenLop.Contains(keyword))
                           .ToList();

            dataGridView1.DataSource = ketQua;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling(
            (double)db.LopHocs.Count() / pageSize);

            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }
        private int TotalPages()
        {
            return (int)Math.Ceiling(
                (double)db.LopHocs.Count() / pageSize);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentPage = TotalPages();
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui long chon lop hoc!");
                return;
            }
            string MaLop = textBox2.Text;
            var dssv = db.SinhViens.Where(x => x.MaLop == MaLop).ToList();
            dataGridView1.DataSource = dssv;
        }
    }
}
