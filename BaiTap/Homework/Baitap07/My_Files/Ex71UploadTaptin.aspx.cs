using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BaiTap.Homework.Baitap07.My_Files
{
    public partial class Ex71UploadTaptin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    if (FileUpload1.HasFile)
        //    {
        //        string kieu = Path.GetExtension(FileUpload1.FileName).ToLower();
        //        if (kieu != ".txt" && kieu != ".xml")
        //        {
        //            lblKetQua.Text = "Chỉ được phép Upload tập tin có định dạng TXT hoặc XML";
        //            lblKetQua.ForeColor = System.Drawing.Color.Red;
        //        }
        //        else
        //        {
        //            string duongdan = Server.MapPath("../My_Files");
        //            FileUpload1.SaveAs(duongdan + "/" + FileUpload1.FileName);
        //            lblKetQua.Text = "Upload thành công";
        //        }
        //    }
        //    else
        //    {
        //        lblKetQua.Text = "Vui lòng chọn tập tin cần load";
        //    }
        //}

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string kieufile = Path.GetExtension(FileUpload1.FileName).ToLower();
                if (kieufile == ".txt" || kieufile == ".xml")
                {
                    string path = Server.MapPath("../My_Files");
                    FileUpload1.SaveAs(path + "/" + FileUpload1.FileName);
                    lblKetQua.Text = "Upload thành công tập tin "+FileUpload1.FileName;
                }
                else
                {
                    lblKetQua.Text = "Chỉ được phép upload tập tin có kiểu là TXT hoặc XML";
                }
            }
            else
            {
                lblKetQua.Text = "Vui lòng chọn tập tin cần upload";
            }
        }
    }
}