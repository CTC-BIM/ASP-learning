using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace BaiTap.Demo
{
    public partial class EXFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            string taptin = Server.MapPath("~/Data/VanBan.txt");
            File.WriteAllText(taptin, txtNoidung.Text, Encoding.Unicode);
        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {
            string taptin = Server.MapPath("~/Data/VanBan.txt");
            string noiDung = File.ReadAllText(taptin);
            txtNoidung.Text = noiDung;
        }

        protected void btnXoaNoiDung_Click(object sender, EventArgs e)
        {
            txtNoidung.Text = "";
        }

        protected void btnDocTheoDong_Click(object sender, EventArgs e)
        {
            string taptin = Server.MapPath("~/Data/VanBan.txt");
            string[] noiDung = File.ReadAllLines(taptin);

        }

        protected void btnDemo_Click(object sender, EventArgs e)
        {
            string path1 = Server.MapPath("~/Data/VanBan.txt");
            string path2 = Server.MapPath("~/LuuTru/VanBan.bak");
            File.Copy(path1, path2);
            //if (File.Exists(path1))
            //{
            //    File.Delete(path1);
            //}

            Directory.CreateDirectory(@"D:\ASP.NET Directory"); //tạo thư mục trên ổ đĩa
            File.Copy(@"C:\Windows\win.ini", @"D:\ASP.NET Directory");


            FileInfo f = new FileInfo(@"D:\ASP.NET Directory");
            DirectoryInfo d = new DirectoryInfo(@"C:\Windows");
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                string pathAndFileName = Server.MapPath("~/Data/" + fileName);
                FileUpload1.SaveAs(pathAndFileName);
            }
        }
    }
}