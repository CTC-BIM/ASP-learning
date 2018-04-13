using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Text;

namespace BaiTap.Homework.Baitap07.My_Files
{
    public partial class EX72CountLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReadAndCount_Click(object sender, EventArgs e)
        {
            if (fUL1.HasFile)
            {
                string filetype = Path.GetExtension(fUL1.FileName).ToLower();
                if (filetype == ".xml" || filetype == ".txt")
                {
                    string path = Server.MapPath("../My_Files");
                    fUL1.SaveAs(path + "/" + fUL1.FileName);
                    lblKetQua.Text = "Lưu file thành công lên server";
                    string fileDaLuu = path + "/" + fUL1.FileName;

                    int soDong = 0;
                    FileStream fs = new FileStream(fileDaLuu,FileMode.Open);
                    StreamReader filecontent = new StreamReader(fs);
                    //noidungfile = StreamReader
                    while (filecontent.ReadLine() != null)
                    {
                        soDong++;
                    }
                    lblKetQua.Text = "Tập tin " +fUL1.FileName + " có " + soDong + " dòng";
                }
                else
                {
                    lblKetQua.Text = "Chỉ đọc được các file có định dạng TXT hoặc XML";
                }
            }
            else
            {
                lblKetQua.Text = "Bạn cần chọn file";
                lblKetQua.ForeColor = Color.Red;
            }
        }
    }
}