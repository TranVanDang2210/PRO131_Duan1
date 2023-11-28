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
    public partial class form_dkll : Form
    {
        duan1 db = new duan1();
        public form_dkll()
        {
            InitializeComponent();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string id = IDRamdom();
            string ngayLam = ngaylam_ip.Text;
            string caLam = calam_ip.Text;
            if (string.IsNullOrWhiteSpace(ngayLam))
            {
                MessageBox.Show("NHẬP NGÀY LÀM!");
            }
            else if (string.IsNullOrWhiteSpace(caLam))
            {
                MessageBox.Show("NHẬP CA LÀM");
            }
            else
            {
                LICHLAM add = new LICHLAM
                {
                    id = id,
                    manv = valll.nhanvien.manv,
                    caLam = caLam,
                    ngayLam = ngayLam,
                    trangThai = "CHƯA DUYỆT"
                };
                db.LICHLAMs.Add(add);
                db.SaveChanges();
                MessageBox.Show("ĐĂNG KÍ LỊCH LÀM THÀNH CÔNG!");
                dataGridView1.DataSource = db.LICHLAMs.ToList();

            }

        }


        private void form_dkll_Load(object sender, EventArgs e)
        {
            var lichLamList = db.LICHLAMs
























                    
            .Where(l => l.manv == valll.nhanvien.manv)
            .ToList();
            dataGridView1.DataSource = lichLamList;
        }

        private void form_dkll_Load_1(object sender, EventArgs e)
        {
            var htll = db.LICHLAMs.Where(x => x.manv == valll.nhanvien.manv).ToList();
            dataGridView1.DataSource = htll;
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
