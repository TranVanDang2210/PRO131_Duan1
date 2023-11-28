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
    public partial class form_home : Form
    {
        private Form acform;

        public form_home()
        {
            InitializeComponent();
        }
        private void form_home_Load(object sender, EventArgs e)
        {
            setTenCN();
        }
        public void setTenCN()
        {
            if(valll.nhanvien.chucVu =="Quản lý")
            {
                htform(new form_qlnv());
                cn1_bt.Text = "QUẢN LÝ NHÂN VIÊN";
                cn2_bt.Text = "QUẢN LÝ TỒN KHO";
                cn3_bt.Text = "QUẢN LÝ MENU";
                cn4_bt.Text = "QUẢN LÝ LỊCH LÀM";
            }else if (valll.nhanvien.chucVu == "Nhân viên thu ngân")
            {
                htform(new form_tinhtien());
                cn1_bt.Text = "TÍNH TIỀN";
                cn2_bt.Text = "BÁO CÁO CUỐI NGÀY";
                cn3_bt.Text = "LỊCH LÀM";

            }
            else if (valll.nhanvien.chucVu == "Nhân viên pha chế")
            {
                htform(new form_dsmon());
                cn1_bt.Text = "MÓN CẦN LÀM";
                cn2_bt.Text = "BÁO CÁO KHO";
                cn3_bt.Text = "LỊCH LÀM";
            }
            else if (valll.nhanvien.chucVu == "Nhân viên phục vụ")
            {
                htform(new form_order());
                cn1_bt.Text = "ORDER";
                cn2_bt.Text = "LỊCH LÀM";

            }
        }
        public void setOnclickCN1(string chucvu)
        {
            if(chucvu == "Quản lý")
            {
                htform(new form_qlnv());
            }else if(chucvu =="Nhân viên thu ngân")
            {
                htform(new form_tinhtien());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_dsmon());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {
                htform(new form_order());
            }
        }
        public void setOnclickCN2(string chucvu)
        {
            if (chucvu == "Quản lý")
            {
                htform(new form_qltk());
            }
            else if (chucvu == "Nhân viên thu ngân")
            {
                htform(new form_baocaocuoingay());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_baocaokho());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {
                htform(new form_dkll());
            }
        }
        public void setOnclickCN3(string chucvu)
        {
            if (chucvu == "Quản lý")
            {
                htform(new form_qlmenu());
            }
            else if (chucvu == "Nhân viên thu ngân")
            {
                htform(new form_dkll());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_dkll());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {

            }
        }
        public void setOnclickCN4(string chucvu)
        {
            if(chucvu == "Quản lý")
            {
                htform(new form_qlll());
            }
        }
        public void htform(Form f)
        {
            if (acform != null)
            {
                acform.Close();
            }
            f.TopLevel = false;
            acform = f;
            f.Parent = hienthiform_pn;

            f.Size = hienthiform_pn.Size;
            f.Location = new Point(0, 0);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            hienthiform_pn.Controls.Add(f);
            tenchucnang_lb.Text = f.Text;
            f.Show();
        }

        private void cn1_bt_Click(object sender, EventArgs e)
        {
            setOnclickCN1(valll.nhanvien.chucVu);
        }

        private void cn2_bt_Click(object sender, EventArgs e)
        {
            setOnclickCN2(valll.nhanvien.chucVu);
        }

        private void cn3_bt_Click(object sender, EventArgs e)
        {
            setOnclickCN3(valll.nhanvien.chucVu);
        }

        private void cn4_bt_Click(object sender, EventArgs e)
        {
            setOnclickCN4(valll.nhanvien.chucVu);
        }
    }

    public static class valll
    {
        public static NHANVIEN nhanvien { get; set; }

    }




}
