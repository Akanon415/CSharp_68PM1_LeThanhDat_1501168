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
    public partial class UserControl1 : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<SinhVien> dssv = db.SinhViens.ToList();
            dataGridView1.DataSource = dssv ;
            LoadDSLH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sinhvien = new SinhVien();
            sinhvien.MaSoSinhVien = textBox1.Text;
            sinhvien.HoTen = textBox2.Text;
            sinhvien.GioiTinh = comboBox1.Text;
            sinhvien.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
            sinhvien.MaLop = comboBox2.SelectedValue.ToString();
            try
            {
                db.SinhViens.InsertOnSubmit(sinhvien);
                db.SubmitChanges();
                MessageBox.Show("Them moi sinh vien thanh cong.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadData()
        {
            List<SinhVien> dssv = db.SinhViens.ToList();
            dataGridView1.DataSource = dssv;
        }
        public void LoadDSLH() // load danh sach du lieu cho combo box o lop hoc
        {
            List<LopHoc> dslh = db.LopHocs.ToList();
            comboBox2.DataSource = dslh;
            comboBox2.DisplayMember = "TenLop";
            comboBox2.ValueMember = "MaLop";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["MaSoSinhVien"].Value.ToString();
                textBox2.Text = row.Cells["HoTen"].Value.ToString();
                comboBox1.Text = row.Cells["GioiTinh"].Value.ToString();

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                comboBox2.SelectedValue = row.Cells["MaLop"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String MaSoSinhVien = textBox1.Text;

                SinhVien sv = db.SinhViens.FirstOrDefault(x => x.MaSoSinhVien == MaSoSinhVien);

                if (sv != null)
                {
                    sv.HoTen = textBox2.Text;
                    sv.GioiTinh = comboBox1.Text;
                    sv.NgaySinh = dateTimePicker1.Value;
                    sv.MaLop = comboBox2.SelectedValue.ToString();
                    db.SubmitChanges();
                    MessageBox.Show("Cap nhat thanh cong!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Khong tim thay sinh vien!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
