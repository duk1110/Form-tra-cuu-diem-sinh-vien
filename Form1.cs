using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string HoTen { get; set; }
            public string LopHoc { get; set; }
            public string Diem { get; set; }  // Điểm
        }

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString() ?? ""; // Sử dụng textBox4 cho điểm
            }
        }

        private void HienThiDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = textBox1.Text,
                HoTen = textBox2.Text,
                LopHoc = textBox3.Text,
                Diem = textBox4.Text 
            };
            danhSachSinhVien.Add(sv);
            HienThiDanhSach();
            XoaTextBox();
        }

        private void XoaTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;

            if (index >= 0 && index < danhSachSinhVien.Count)
            {
                danhSachSinhVien[index].MaSinhVien = textBox1.Text;
                danhSachSinhVien[index].HoTen = textBox2.Text;
                danhSachSinhVien[index].LopHoc = textBox3.Text;
                danhSachSinhVien[index].Diem = textBox4.Text; 
                HienThiDanhSach();
                XoaTextBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;

            if (index >= 0 && index < danhSachSinhVien.Count)
            {
                danhSachSinhVien.RemoveAt(index);
                HienThiDanhSach();
                XoaTextBox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maSV = textBox4.Text.Trim();

            SinhVien sv = danhSachSinhVien.FirstOrDefault(s => s.MaSinhVien == maSV);

            if (sv != null)
            {
                MessageBox.Show($"Mã: {sv.MaSinhVien}\n" +
                                $"Họ Tên: {sv.HoTen}\n" +
                                $"Lớp: {sv.LopHoc}\n" +
                                $"Điểm: {sv.Diem}\n", "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
