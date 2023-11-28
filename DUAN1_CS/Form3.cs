﻿using System;
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
    public partial class form_qlnv : Form
    {
        duan1 db = new duan1();

        public form_qlnv()
        {
            InitializeComponent();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string manv = MaNVRamdom();
            string ten = ten_ip.Text;
            string sdt = sdt_ip.Text;
            string gioitinh = setGT();
            string diachi = diachi_ip.Text;
            string vitrilam;
            string chucvu;
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN!");
            }
            else if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("NHẬP SĐT!");
            }
            else if (String.IsNullOrWhiteSpace(gioitinh))
            {
                MessageBox.Show("CHỌN GIƠI TÍNH");
            }
            else if (string.IsNullOrWhiteSpace(diachi))
            {
                MessageBox.Show("NHẬP ĐỊA CHỈ");
            }
            else if (vitrilam_cbb.SelectedItem == null)
            {
                MessageBox.Show("CHỌN VỊ TRÍ LÀM!");
            }
            else if (chucvu_cbb.SelectedItem == null)
            {
                MessageBox.Show("CHỌN CHỨC VỤ!");
            }
            else
            {
                vitrilam = vitrilam_cbb.SelectedItem.ToString();
                chucvu = chucvu_cbb.SelectedItem.ToString();

                NHANVIEN newNV = new NHANVIEN
                {
                    manv = manv,
                    tenNV = ten,
                    sdt = sdt,
                    diaChi = diachi,
                    gioiTinh = gioitinh,
                    vitrilam = vitrilam,
                    chucVu = chucvu,
                    matKhau = "111"
                };
                db.NHANVIENs.Add(newNV);
                db.SaveChanges();
                MessageBox.Show("ĐÃ THÊM NHÂN VIÊN MỚI!");
                dataGridView1.DataSource = db.NHANVIENs.ToList();

            }




        }

        private void sua_bt_Click(object sender, EventArgs e)
        {
            string ten = ten_ip.Text;
            string sdt = sdt_ip.Text;
            string gioitinh = setGT();
            string diachi = diachi_ip.Text;
            string vitrilam;
            string chucvu;
            var checkTen = db.NHANVIENs.Any(x=>x.tenNV == ten);
            if (!checkTen)
            {
                MessageBox.Show("TÊN KHÔNG TỒN TẠI \r VUI LÒNG NHẬP TÊN NHÂN VIÊN CẦN SỬA!");
            }
            else if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("NHẬP SĐT!");
            }
            else if (String.IsNullOrWhiteSpace(gioitinh))
            {
                MessageBox.Show("CHỌN GIỚI TÍNH");
            }
            else if (string.IsNullOrWhiteSpace(diachi))
            {
                MessageBox.Show("NHẬP ĐỊA CHỈ");
            }
            else if (vitrilam_cbb.SelectedItem == null)
            {
                MessageBox.Show("CHỌN VỊ TRÍ LÀM!");
            }
            else if (chucvu_cbb.SelectedItem == null)
            {
                MessageBox.Show("CHỌN CHỨC VỤ!");
            }
            else
            {
                vitrilam = vitrilam_cbb.SelectedItem.ToString();
                chucvu = chucvu_cbb.SelectedItem.ToString();
                var changNV = db.NHANVIENs.FirstOrDefault(x => x.tenNV == ten);
                changNV.sdt = sdt;
                changNV.gioiTinh = gioitinh;
                changNV.diaChi = diachi;
                changNV.vitrilam= vitrilam;
                changNV.chucVu = chucvu;
                db.SaveChanges();
                MessageBox.Show("ĐÃ SỬA THÔNG TIN NHÂN VIÊN  " + ten);
                dataGridView1.DataSource = db.NHANVIENs.ToList();
            }
        }

        private void xoa_bt_Click(object sender, EventArgs e)
        {
            string ten = ten_ip.Text;
            var checkTen = db.NHANVIENs.Any(x => x.tenNV == ten);
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN NHÂN VIÊN CẦN XÓA");
            }else if (!checkTen)
            {
                MessageBox.Show("TÊN KHÔNG TỒN TẠI\r \t VUI LÒNG NHẬP TÊN NHÂN VIÊN CẦN XÓA!");
            }
            else
            {
                var deleteNV = db.NHANVIENs.FirstOrDefault(x=>x.tenNV == ten);
                db.NHANVIENs.Remove(deleteNV);
                db.SaveChanges();
                dataGridView1.DataSource= db.NHANVIENs.ToList();
                MessageBox.Show("ĐÃ XÓA NHÂN VIÊN  "+ten);
            }
        }
        public string setGT()
        {
            if (nam.Checked)
            {
                return "Nam";
            }
            else if (nu.Checked)
            {
                return "Nữ";
            }
            else
            {
                return null;
            }
        }
        public string MaNVRamdom()
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

                randomString = "NV_" + result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

                var check = db.NHANVIENs.Any(x => x.manv == randomString);

                if (!check)
                {
                    break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
                }
            }

            return randomString;
        }

        private void form_qlnv_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NHANVIENs.ToList();
        }
    }
}
