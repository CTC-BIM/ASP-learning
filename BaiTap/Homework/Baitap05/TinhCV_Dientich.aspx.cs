using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework.Baitap05
{
    public partial class TinhCV_Dientich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtCanh.Focus();
            }
        }

        protected void rbtnVuong_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        protected void rbtnChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            double canh, chieuDai, chieuRong = 0;
            try
            {
                if (rbtnVuong.Checked)
                {
                    canh = double.Parse(txtCanh.Text);
                    HinhVuong2 hV = new HinhVuong2();
                    hV.Canh = canh;
                    txtKetQua.Text = hV.XuatThongTin();
                }
                else if (rbtnChuNhat.Checked)
                {
                    chieuDai = double.Parse(txtChieuDai.Text);
                    chieuRong = double.Parse(txtChieuRong.Text);
                    HinhChuNhat2 hCN = new HinhChuNhat2();
                    hCN.ChieuDai = chieuDai;
                    hCN.ChieuRong = chieuRong;
                    txtKetQua.Text = hCN.XuatThongTin();
                }
            }
            catch (FormatException) { txtKetQua.Text = "Các cạnh phải là số và có chiều dài >=0"; }
            catch (Exception) { txtKetQua.Text = "Đã có lỗi xãy ra"; }

        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtCanh.Text = txtChieuDai.Text = txtChieuRong.Text = txtKetQua.Text = "";
            txtCanh.Focus();
        }
    }
}