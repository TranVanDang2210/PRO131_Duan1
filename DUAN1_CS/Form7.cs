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
    public partial class form_order : Form
    {
        duan1 db = new duan1();
        public form_order()
        {
            InitializeComponent();
        }
        private void form_order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dU_AN_1DataSet.MENU' table. You can move, or remove it, as needed.
            this.mENUTableAdapter.Fill(this.dU_AN_1DataSet.MENU);
            dataGridView1.DataSource = db.BILLs.ToList();

        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string id = IDRamdom();
            string maBan = maban_ip.Text;
            string tenMon = mon_cbb.Text;
            string maMon = "";
            string soluong = soluong_ip.Text;
            int number;
            var checkmaban = db.BANs.Any(x => x.maBan == maBan);
            maMon = (from a in db.MENUs
                     where tenMon== a.tenMon
                     select a.maMon).FirstOrDefault();
            var checkMon = (from x in db.MENUs
                            where x.maMon == maMon
                            select x.tenMon).Any();
            if (string.IsNullOrWhiteSpace(maBan))
            {
                MessageBox.Show("NHẬP MÃ BÀN!");
            }else if (!checkmaban)
            {
                MessageBox.Show("BÀN KHÔNG TỒN TẠI!");
            }
            else if(string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show("NHẬP HOẶC CHỌN MÓN!");
            }else if (!checkMon)
            {
                MessageBox.Show("MÓN KHÔNG CÓ TRONG MENU!");
            }
            else if (string.IsNullOrWhiteSpace(soluong)){
                MessageBox.Show("CHỌN SỐ LƯỢNG!");  
            }else if(!int.TryParse(soluong,out number))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG LÀ SỐ!");
            }
            else
            {
                BILL newOrder = new BILL
                {
                    id = id,
                    maBan = maBan,
                    maMon = maMon,
                    soluong = Convert.ToInt32(soluong),
                };
                db.BILLs.Add(newOrder);
                db.SaveChanges();
                MessageBox.Show("ORDER MÓN THÀNH CÔNG!");
                dataGridView1.DataSource = db.BILLs.ToList();
            }
        }


        private void sua_bt_Click(object sender, EventArgs e)
        {
            //int id;
            string maBan = maban_ip.Text;
            string tenMon = mon_cbb.Text;
            string maMon = "";
            string soluong = soluong_ip.Text;
            int number;
            var checkmaban = db.BANs.Any(x => x.maBan == maBan);
            maMon = (from a in db.MENUs
                     where tenMon == a.tenMon
                     select a.maMon).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(maBan))
            {
                MessageBox.Show("NHẬP MÃ BÀN!");
            }
            else if (!checkmaban)
            {
                MessageBox.Show("BÀN KHÔNG TỒN TẠI!");
            }
            else if (string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show("NHẬP HOẶC CHỌN MÓN!");
            }
            else if (string.IsNullOrWhiteSpace(soluong))
            {
                MessageBox.Show("CHỌN SỐ LƯỢNG!");
            }
            else if (!int.TryParse(soluong, out number))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG LÀ SỐ!");
            }
            else
            {
                var takeID = (from x in db.BILLs
                                 where x.maBan == maBan
                                 select x.id).FirstOrDefault();
                var changBill = db.BILLs.FirstOrDefault(x=>x.id== takeID);
                var checkMon = db.BILLs.Any(x=>x.maMon== maMon);
                if(!checkMon)
                {
                    MessageBox.Show("BÀN HIỆN TẠI KHÔNG CÓ MÓN NÀY!");
                }
                else
                {
                    changBill.soluong = Convert.ToInt32(soluong);
                    MessageBox.Show("ĐÃ SỬA THÔNG TIN BÀN");
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

        private void xoa_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
