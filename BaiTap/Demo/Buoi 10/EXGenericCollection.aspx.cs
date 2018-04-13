using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo.Buoi_10
{
    public partial class EXGenericCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsSinhvien = new List<SinhVien>();//khai báo kiểu dữ liệu trước khi sử dụng
            dsSinhvien.Add(new SinhVien("001", "nguyen tv", 3));
            dsSinhvien.Add(new SinhVien("002", "qweqwe", 3));
            dsSinhvien.Add(new SinhVien("003", "qweqwetv",2));
            dsSinhvien.Add(new SinhVien("004", "nwe",7));

            double tongDiem = 0;
            foreach (SinhVien sv  in dsSinhvien)
            {
                tongDiem += sv.Diem;
            }
            //LinqtoObject
            double tongDiem2 = dsSinhvien.Sum(p => p.Diem);//Trả về tổng điểm, dùng lamda expression, p chỉ là ký tự đại diện cho 1 phần tử bên trong list
            double maxDiem = dsSinhvien.Max(s => s.Diem);//trả về Max điểm
            List<SinhVien> dsSVGioi = dsSinhvien.Where(p => p.Diem == maxDiem).ToList();



        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dssp = new Dictionary<string, int>();
            dssp.Add("sp01", 02);
            dssp.Add("sp02", 02);
            dssp.Add("sp03", 02);
            dssp.Add("sp04", 02);

            int tong = dssp["sp02"] + dssp["sp03"];//trả về
            int kqtong = 0;
            foreach (KeyValuePair<string,int> pt in dssp)
            {
                kqtong += pt.Value;
            }


        }
    }
}