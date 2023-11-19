﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace nhom_9
{
    [Serializable]
    public partial class frm_dat_lich : Form
    {
        DanhSachDatLich dsdatlich;
        DatLich dl;
       
        public frm_dat_lich()
        {
            InitializeComponent();
        }
        
        private void frm_dat_lich_Load(object sender, EventArgs e)
        {
            dtp_thoigian.Text = DateTime.Now.ToString();
             
            dsdatlich = new DanhSachDatLich();
            dl=new DatLich();
            //Doc file
         
           string[] tam = File.ReadAllLines("danhsachdatlich.txt");
            for (int i = 0; i < tam.Length; i++)
            {
                string line = tam[i];
                string[] tam2 = line.Split("\t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                DatLich datLich = new DatLich();
                datLich.id = int.Parse(tam2[0]);
                datLich.tieude = tam2[1];
                datLich.noidung = tam2[2];
                datLich.thoigian = Convert.ToDateTime(tam2[3]);
                datLich.trangthai = tam2[4];
                dl = new DatLich(datLich.id, datLich.tieude, datLich.noidung, datLich.thoigian, datLich.trangthai);
                dsdatlich.AddDanhSachDatLich(dl);
            }
            hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);
           
        }
        private void hienthidanhsachdatlich(DataGridView dgv,List<DatLich>ds)
        {
            dgv.DataSource = ds;
        }

        private void btn_luu_lich_Click(object sender, EventArgs e)
        {
            if (txt_tieude.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tiêu đề ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //luu lich
                int ip = dsdatlich.tao_ID(dl);

                string trangthai;
                if (rad_hoanthanh.Checked == true)
                {
                    trangthai = "Hoàn thành ";

                }
                else
                    trangthai = "Chưa hoàn thành";
                dtp_thoigian.Focus();
                dl = new DatLich(ip, txt_tieude.Text, txt_noidung.Text, Convert.ToDateTime(dtp_thoigian.Text), trangthai);
                if (dsdatlich.timTG(dl))
                {
                    MessageBox.Show("Thời gian bị trùng. Mời bạn đặt lại thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    TimeSpan time =Convert.ToDateTime( dtp_thoigian.Text).Subtract(DateTime.Now);
                    int phuttoido = time.Minutes;
                    if (phuttoido >= 30)
                    {
                        dsdatlich.AddDanhSachDatLich(dl);
                        hienthidanhsachdatlich(dgv_danhsach, dsdatlich.danhSachDatLich);

                        //Ghi File
                        try
                        {
                            StreamWriter swt = new StreamWriter("danhsachdatlich.txt", false, Encoding.UTF8);
                            foreach (DatLich datLich in dsdatlich.danhSachDatLich)
                            {
                                string dong = datLich.id.ToString() + "\t" + datLich.tieude + "\t" + datLich.noidung + "\t" + datLich.thoigian.ToString() + "\t" + datLich.trangthai;
                                swt.WriteLine(dong);
                            }
                            swt.Close();
                            MessageBox.Show("Lịch đã lưu thành công  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Lịch lưu thất bại ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thời gian không phù hợp. Mời bạn chọn lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btn_tao_moi_Click(object sender, EventArgs e)
        {

                    
                        txt_tieude.Text = "";
                        txt_noidung.Text = "";
                        dtp_thoigian.Value = DateTime.Now;
                        rad_hoanthanh.Checked = false;
                    
        
        }

        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}