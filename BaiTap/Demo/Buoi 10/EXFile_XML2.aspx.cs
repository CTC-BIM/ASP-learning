using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;

namespace BaiTap.Demo.Buoi_10
{
    public partial class EXFile_XML2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //1-XML
            XmlDocument tailieu = new XmlDocument();
            //2-tạo node gốc
            XmlElement rootNode = tailieu.CreateElement("DanhSachSinhVien");
            tailieu.AppendChild(rootNode);

            //3-tạo node con cap 1
            XmlElement sinhvienNode = tailieu.CreateElement("SinhVien");
            rootNode.AppendChild(sinhvienNode);

            //Buoi 10---------------------------------------------------------------------------------------
            //4-tao va gan gia tri cho cac thuoc tinh cua sinhvienNode
            sinhvienNode.SetAttribute("MaSo", txtMaSo.Text);
            sinhvienNode.SetAttribute("Hoten", txtHoTen.Text);
            //Buoi 10---------------------------------------------------------------------------------------


            //5-Luu thanh tap tin XML
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien2.xml");
            tailieu.Save(duongDanTenFile);
            lblKetQua.Text = "Tạo tập tin thành công!";

        }


        protected void btnThemNode_Click(object sender, EventArgs e)
        {
            //1- XML
            XmlDocument tailieu = new XmlDocument();
            //2- load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien2.xml");
            tailieu.Load(duongDanTenFile);
            //3- tham chieu den node goc
            XmlElement rootNode = tailieu.DocumentElement;

            //4- tạo node con
            XmlElement sinhvienNode = tailieu.CreateElement("SinhVien");
            rootNode.AppendChild(sinhvienNode);

            //Buoi 10---------------------------------------------------------------------------------------
            //5-tao va gan gia tri cho cac thuoc tinh cua sinhvienNode
            sinhvienNode.SetAttribute("MaSo", txtMaSo.Text);
            sinhvienNode.SetAttribute("Hoten", txtHoTen.Text);
            //Buoi 10---------------------------------------------------------------------------------------

            //6-Luu thanh tap tin XML
            tailieu.Save(duongDanTenFile);
            lblKetQua.Text = "Tạo tập tin thành công!";

        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {
            //1-XML
            XmlDocument tailieu = new XmlDocument();
            //2-load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien2.xml");
            tailieu.Load(duongDanTenFile);
            //3-tham chieu den các element có tag là sinh vien
            XmlNodeList dsSV = tailieu.GetElementsByTagName("SinhVien");

            ////Doc noi dung SV dau tien trong danh sach
            //XmlNode sv1 = dsSV[0];
            //string maso1 = sv1["MaSo"].InnerText;
            //string hoten1 = sv1["Hoten"].InnerText;

            //Buoi 10---------------------------------------------------------------------------------------
            //Đoc danh sach và dưa lên lable
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode svitem in dsSV)
            {
                string maso = svitem.Attributes["MaSo"].InnerText;
                string hoten = svitem.Attributes["Hoten"].InnerText;
                sb.AppendFormat("{0} - {1}</br>", maso, hoten);
            }
            //Buoi 10--------------------------------------------------------------------------------------

            lblKetQua.Text = sb.ToString();


        }


        protected void btnXuatDanhSach_Click(object sender, EventArgs e)
        {
            //XML
            XmlDocument tailieu = new XmlDocument();
            //load noi dung từ tập tin xml
            string duongDanTenFile = Server.MapPath(@"~/Data/Sinhvien2.xml");
            tailieu.Load(duongDanTenFile);
            //tạo node con
            XmlNodeList svNodeList = tailieu.GetElementsByTagName("SinhVien");

            SinhVien[] arrSinhVien = new SinhVien[svNodeList.Count];

            //Buoi 10---------------------------------------------------------------------------------------
            for (int i = 0; i < svNodeList.Count; i++)
            {
                XmlNode sv = svNodeList[i];
                string maso = sv.Attributes["MaSo"].InnerText;
                string hoten = sv.Attributes["Hoten"].InnerText;
                arrSinhVien[i] = new SinhVien(maso, hoten);
            }
            //Buoi 10---------------------------------------------------------------------------------------

            // Xuat len grid
            gridViewSinhVien.DataSource = arrSinhVien;
            gridViewSinhVien.DataBind();
        }

    }
}
