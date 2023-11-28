using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_CS
{
    public partial class form_qlll : Form
    {
        duan1 db = new duan1();
        public form_qlll()
        {
            InitializeComponent();
        }
        private void form_qlll_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LICHLAMs.ToList();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string id = IDRamdom();
            string maNV = manv_ip.Text;
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("NHẬP MÃ NHÂN VIÊN!");
            }
            else if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                var addLL = new LICHLAM
                {
                    id= id,
                    manv = maNV,
                    caLam = caLam,
                    ngayLam = ngayLam
                };
                db.LICHLAMs.Add(addLL);
                db.SaveChanges();
                MessageBox.Show("ĐÃ THÊM LỊCH LÀM CHO NHÂN VIÊN!");
                dataGridView1.DataSource = db.LICHLAMs.ToList();

            }
        }

        private void sua_bt_Click(object sender, EventArgs e)
        {
            string maNV = manv_ip.Text;
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("NHẬP MÃ NHÂN VIÊN!");
            }
            else if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                var changLL = db.LICHLAMs.FirstOrDefault(x => x.manv == maNV);
                changLL.caLam = caLam;
                changLL.ngayLam = ngayLam;
                db.SaveChanges();
                MessageBox.Show("ĐÃ SỬA LỊCH LÀM CỦA NHÂN VIÊN " + maNV);
                dataGridView1.DataSource = db.LICHLAMs.ToList();
                ;
            }
        }

        private void xoa_bt_Click_1(object sender, EventArgs e)
        {
            string maNV = manv_ip.Text;
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("NHẬP MÃ NHÂN VIÊN!");
            }
            else if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                var removeLL = db.LICHLAMs.Where(
                                            (x => x.manv == maNV && x.caLam == caLam && x.ngayLam == ngayLam))
                                            .FirstOrDefault();
                if (removeLL != null)
                {
                    db.LICHLAMs.Remove(removeLL);
                    db.SaveChanges() ;
                    MessageBox.Show("ĐÃ XÓA LỊCH LÀM KHỎI DANH SÁCH!");
                    dataGridView1.DataSource = db.LICHLAMs.ToList();
                }
                else
                {
                    MessageBox.Show($"KHÔNG TÌM THẤY CA LÀM CỦA NHÂN VIÊN CÓ {maNV} ");
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNV = manv_ip.Text;
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("NHẬP MÃ NHÂN VIÊN!");
            }
            else if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                var checkLL = db.LICHLAMs.Where(
                                            (x => x.manv == maNV && x.caLam == caLam && x.ngayLam == ngayLam))
                                            .FirstOrDefault();
                if(checkLL != null)
                {
                    checkLL.trangThai = "ĐÃ DUYỆT";
                    db.SaveChanges();
                    dataGridView1.DataSource = db.LICHLAMs.ToList();
                    MessageBox.Show("DUYỆT THÀNH CÔNG!");
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ LỊCH LÀM HỢP LỆ!");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                manv_ip.Text = dr.Cells[1].Value.ToString();
                calam_ip.Text = dr.Cells[2].Value.ToString();
                ngaylam_ip.Text = dr.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maNV = manv_ip.Text;
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("NHẬP MÃ NHÂN VIÊN!");
            }
            else if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                var checkLL = db.LICHLAMs.Where(
                                            (x => x.manv == maNV && x.caLam == caLam && x.ngayLam == ngayLam))
                                            .FirstOrDefault();
                if (checkLL != null)
                {
                    checkLL.trangThai = "TỪ CHỐI DUYỆT";
                    db.SaveChanges();
                    dataGridView1.DataSource = db.LICHLAMs.ToList();
                    MessageBox.Show("ĐÃ BỎ DUYỆT!");
                }
                else
                {
                    MessageBox.Show("KHÔNG CÓ LỊCH LÀM HỢP LỆ!");
                }
            }
        }
        public string IDRamdom()
    {
        Random random = new Random();
        const string chars = "0123456789";
        string randomString = "";

        while (true)
        {
            StringBuilder result = new StringBuilder(); // Reset StringBuilder
            for (int i = 0; i < 3; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            randomString = "ID_" + result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

            var check = db.MENUs.Any(x => x.maMon == randomString);

            if (!check)
            {
                break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
            }
        }

        return randomString;
    }
    }

}
