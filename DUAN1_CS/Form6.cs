using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_CS
{
    public partial class form_tinhtien : Form
    {
        duan1 db = new duan1();
        List<string> listMon = new List<string>();
        List<int?> listSL = new List<int?>();
        List<double?> listGia = new List<double?>();
        string banTT = "";


        public form_tinhtien()
        {
            InitializeComponent();
        }

        private void form_tinhtien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.BANs.ToList();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                banTT= dr.Cells[0].Value.ToString();
                htMOn(banTT);

                dsmon.Items.Clear();
                    foreach(var x in listMon)
                    {
                        dsmon.Items.Add(x.ToString());
                    }
                
            }
        }

        private void tinhtien_bt_Click(object sender, EventArgs e)
        {
            string bill = "";
            double? sum = 0;
            for (int i = 0; i < listMon.Count; i++)
            {
                bill += listMon[i] + "\t\t" + listGia[i] + "\t\t" + listSL[i] + "\t\t" + (listGia[i] * listSL[i]) + "\r";
                var temp = listGia[i] * listSL[i];
                sum += temp;
            };
            MessageBox.Show("\t\t\tHÓA ĐƠN BÀN "+banTT+
                "\rTÊN MÓN  \t   GIÁ MÓN   \t  SỐ LƯỢNG   \t  TỔNG TIỀN\r" + bill+"\r " +
                "----------------------------------------------------------------------------------------------\r" +
                "\t\t\t\t\tTỔNG : "+sum+" VND");
        }
        public string MaMonRamdom()
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

                randomString = "ID_"+ result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

                var check = db.MENUs.Any(x => x.maMon == randomString);

                if (!check)
                {
                    break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
                }
            }

            return randomString;
        }
        public void htMOn(string ban)
        {
            listMon = (from x in db.MENUs
                        join b in db.BILLs on x.maMon equals b.maMon
                        where b.maBan == ban
                        select x.tenMon).ToList();

            listGia = (from x in db.MENUs
                       join b in db.BILLs on x.maMon equals b.maMon
                       where b.maBan == ban
                       select x.gia).ToList();

            listSL = (from x in db.MENUs
                       join b in db.BILLs on x.maMon equals b.maMon
                       where b.maBan == ban
                       select b.soluong).ToList();
        }
    }
}
