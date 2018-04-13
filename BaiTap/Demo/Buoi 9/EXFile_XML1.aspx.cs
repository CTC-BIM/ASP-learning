using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;

namespace BaiTap.Demo
{
    public partial class EXFile_XML1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //XML
            XmlDocument tailieu = new XmlDocument();
            //tạo node gốc
            XmlElement rootNode = tailieu.CreateElement("DanhSachSinhVien");
            tailieu.AppendChild(rootNode);

            //tạo node con
            XmlElement sinhvienNode = tailieu.CreateElement("SinhVien");
            rootNode.AppendChild(sinhvienNode);

            //Tạo node con cấp 2
            XmlElement masoNode = tailieu.CreateElement("MaSo");
            masoNode.InnerText = txtMaSo.Text;
            sinhvienNode.AppendChild(masoNode);

            XmlElement hotenNode = tailieu.CreateElement("Hoten");
            hotenNode.InnerText = txtHoTen.Text;
            sinhvienNode.AppendChild(hotenNode);

            //Luu thanh tap tin XML
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien1.xml");
            tailieu.Save(duongDanTenFile);
            lblKetQua.Text = "Tạo tập tin thành công!";


        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {
            //XML
            XmlDocument tailieu = new XmlDocument();
            //load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien1.xml");
            tailieu.Load(duongDanTenFile);
            //tham chieu den các element có tag là sinh vien
            XmlNodeList svnodeList = tailieu.GetElementsByTagName("SinhVien");

            //Doc noi dung SV dau tien trong danh sach
            XmlNode sv1 = svnodeList[0];
            string maso1 = sv1["MaSo"].InnerText;
            string hoten1 = sv1["Hoten"].InnerText;

            //Đoc danh sach và dưa lên lable
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode svitem in svnodeList)
            {
                string maso = svitem["MaSo"].InnerText;
                string hoten = svitem["Hoten"].InnerText;
                sb.AppendFormat("{0} - {1}</br>", maso, hoten);
            }
            lblKetQua.Text = sb.ToString();


        }

        protected void btnThemNode_Click(object sender, EventArgs e)
        {
            //XML
            XmlDocument tailieu = new XmlDocument();
            //load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien1.xml");
            tailieu.Load(duongDanTenFile);
            //tham chieu den node goc
            XmlElement rootNode = tailieu.DocumentElement;

            //tạo node con
            XmlElement sinhvienNode = tailieu.CreateElement("SinhVien");
            rootNode.AppendChild(sinhvienNode);

            //Tạo node con cấp 2
            XmlElement masoNode = tailieu.CreateElement("MaSo");
            masoNode.InnerText = txtMaSo.Text;
            sinhvienNode.AppendChild(masoNode);

            XmlElement hotenNode = tailieu.CreateElement("Hoten");
            hotenNode.InnerText = txtHoTen.Text;
            sinhvienNode.AppendChild(hotenNode);

            //Luu thanh tap tin XML
            tailieu.Save(duongDanTenFile);
            lblKetQua.Text = "Tạo tập tin thành công!";

        }

        protected void btnXuatDanhSach_Click(object sender, EventArgs e)
        {
            //XML
            XmlDocument tailieu = new XmlDocument();
            //load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien1.xml");
            tailieu.Load(duongDanTenFile);
            //tạo node con
            XmlNodeList svNodeList = tailieu.GetElementsByTagName("SinhVien");

            SinhVien[] arrSinhVien = new SinhVien[svNodeList.Count];

            for (int i = 0; i < svNodeList.Count; i++)
            {
                XmlNode sv = svNodeList[i];
                string maso = sv["MaSo"].InnerText;
                string hoten = sv["Hoten"].InnerText;

                arrSinhVien[i] = new SinhVien(maso, hoten);
            }
            // Xuat len grid
            gridViewSinhVien.DataSource = arrSinhVien;
            gridViewSinhVien.DataBind();
        }
    }
}