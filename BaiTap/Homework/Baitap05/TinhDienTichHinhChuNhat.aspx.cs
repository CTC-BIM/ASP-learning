using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework.Baitap05
{
    public partial class TinhDienTichHinhChuNhat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            double chieuDai = 0;
            double chieuRong = 0;
            try
            {
                chieuDai = double.Parse(txtChieuDai.Text);
                chieuRong = double.Parse(txtChieuRong.Text);
                HinhChuNhat2 hcn = new HinhChuNhat2();
                hcn.ChieuDai = chieuDai;
                hcn.ChieuRong = chieuRong;
                
                txtKetqua.Text = "Hình chữ nhật có diện tích: "+hcn.DienTich().ToString();
            }
            catch (FormatException) { txtKetqua.Text = "Chiều dài và chiều rộng phải là số và >=0"; }
            catch (Exception) { txtKetqua.Text = "Đã có lỗi xãy ra"; }
        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuDai.Text = txtChieuRong.Text = txtKetqua.Text = "";
            txtChieuDai.Focus();
        }
    }
}