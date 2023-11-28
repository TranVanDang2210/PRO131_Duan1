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
    public partial class form_qltk : Form
    {
        duan1 db = new duan1();
        public form_qltk()
        {
            InitializeComponent();
        }

        private void form_qltk_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.KHOes.ToList();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string maNL = MaNLRamdom();
            string ten = ten_ip.Text;
            string soluong = soluong_ip.Text;
            string gia = gia_ip.Text;
            string ngaynhap = ngaynhap_ip.Text;
            string ngayhethan = ngayhethan_ip.Text;
            string ghichu = ghichu_ip.Text;
            //double number;
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN NGUYÊN LIỆU!");
            } else if (string.IsNullOrWhiteSpace(soluong_ip.Text))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG!");
            }
            /*else if (!double.TryParse(soluong_ip.Text, out number))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG LÀ SỐ!");
            }*/
            else if(string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("NHẬP GIÁ");
            }else if(string.IsNullOrWhiteSpace(ngaynhap))
            {
                MessageBox.Show("NHẬP NGÀY NHẬP NGUYÊN LIỆU!");
            }else if(string.IsNullOrWhiteSpace(ngayhethan))
            {
                MessageBox.Show("NHẬP NGÀY HẾT HẠN NGUYÊN LIỆU!");
            }
            else
            {
                var addNV = new KHO
                {
                    maNL = maNL,
                    tenNL = ten,
                    gia = gia,
                    soluong = soluong,
                    ngayNhap = ngaynhap,
                    ngayHetHan= ngayhethan,
                    ghichu= ghichu,
                };
                db.KHOes.Add(addNV);
                db.SaveChanges();
                MessageBox.Show("THÊM NGUYÊN LIỆU THÀNH CÔNG!");
                dataGridView1.DataSource = db.KHOes.ToList();
            }

        }

        private void sua_bt_Click(object sender, EventArgs e)
        {
            string maNL = MaNLRamdom();
            string ten = ten_ip.Text;
            string soluong = soluong_ip.Text;
            string gia = gia_ip.Text;
            string ngaynhap = ngaynhap_ip.Text;
            string ngayhethan = ngayhethan_ip.Text;
            string ghichu = ghichu_ip.Text;
            double number;
            var checkten = db.KHOes.Any(x=>x.tenNL == ten);

            if (!checkten)
            {
                MessageBox.Show("KHÔNG TÌM THẤY NGUYÊN LIỆU CẦN SỬA");
            }
            else if (string.IsNullOrWhiteSpace(soluong_ip.Text))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG!");
            }
            else if (!double.TryParse(soluong_ip.Text, out number))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG LÀ SỐ!");
            }
            else if (string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("NHẬP GIÁ");
            }
            else if (string.IsNullOrWhiteSpace(ngaynhap))
            {
                MessageBox.Show("NHẬP NGÀY NHẬP NGUYÊN LIỆU!");
            }
            else if (string.IsNullOrWhiteSpace(ngayhethan))
            {
                MessageBox.Show("NHẬP NGÀY HẾT HẠN NGUYÊN LIỆU!");
            }
            else
            {
                var changNL = db.KHOes.FirstOrDefault(x => x.tenNL == ten);
                changNL.tenNL = ten;
                changNL.gia = gia;
                changNL.soluong =  soluong;
                changNL.ngayNhap = ngaynhap;
                changNL.ngayHetHan= ngayhethan;
                changNL.ghichu = ghichu;
                db.SaveChanges();
                MessageBox.Show("ĐÃ SỬA THÔNG TIN NGUYÊN LIỆU  " + ten);
                dataGridView1.DataSource = db.KHOes.ToList();
            }


        }
        private void xoa_bt_Click(object sender, EventArgs e)
        {
            string ten = ten_ip.Text;
            var checkten = db.KHOes.Any(x=>x.tenNL == ten);
            if (!checkten)
            {
                MessageBox.Show("TÊN NGUYÊN LIỆU KHÔNG TỒN TẠI! \r NHẬP TÊN NGUYÊN LIỆU CẦN XÓA");
            }
            else
            {
                var removeNL = db.KHOes.FirstOrDefault(x => x.tenNL == ten);
                db.KHOes.Remove(removeNL);
                db.SaveChanges();
                dataGridView1.DataSource= db.KHOes.ToList();
                MessageBox.Show("ĐÃ XÓA NGUYÊN LIỆU THÀNH CÔNG!");
            }
        }
        public string MaNLRamdom()
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

                randomString = "NL_" + result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

                var check = db.KHOes.Any(x => x.maNL == randomString);

                if (!check)
                {
                    break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
                }
            }

            return randomString;
        }

    }
}
