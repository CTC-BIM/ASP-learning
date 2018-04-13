using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Buoi 10 ---------------------------------------------------------------
using System.Collections;

namespace BaiTap.Demo.Buoi_10
{
    public partial class EXArrayList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList(); //Khởi tao Array list
            a.Add("Xin chào");
            a.Add(500);

            DateTime ngayHienHanh = DateTime.Today;
            SinhVien sv = new SinhVien("SV001","Tran Van A");

            a.Add(ngayHienHanh);
            int vitri = a.Add(sv);
            SinhVien svtruyxuat = a[vitri] as SinhVien;
            string hoTen = svtruyxuat.HoTen;

            DateTime ngaySinh = new DateTime(1985, 2, 15);

            DateTime ns = (DateTime)a[2]; //Ép kiểu của phần tử thứ 2 về kiểu DateTime
            int namsinh = ns.Year;

        }

        protected void btnAddRange_Click(object sender, EventArgs e)
        {
            string[] arrThu = new string[] {"CN","Thứ 2","Thứ 3" };
            ArrayList dsThu = new ArrayList();
            //Để chuyển nội dung từ arrThu sang Array list có 2 cách làm
            // Cách 1: dùng vòng lặp For duyệt hết và ADD vào Arraylist

            //Cách 2:
            dsThu.AddRange(arrThu);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ArrayList dsThu = new ArrayList();
            dsThu.AddRange(new string[] { "CN", "Thứ 2", "Thứ 3","Thứ 7" });

            dsThu.Insert(3, "Thứ 4");
            dsThu.Insert(4, new string[] { "Thứ 5", "Thứ 6" });

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ArrayList dsThu = new ArrayList();
            dsThu.AddRange(new string[] { "CN", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6","Thứ 7" });

            dsThu.Remove("Thứ 2"); //Xóa phần tử theo nội dung
            dsThu.Remove(1); //Remove theo thứ tự của phần tử
            dsThu.RemoveRange(1, 3); //Remove phần tử từ 1 đến 3
            dsThu.Clear();//REmove toàn bộ các phần tử, Arraylist vẫn tồn tại, và chứa 0 phần tử (Count == 0)

        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            ArrayList dsTen = new ArrayList();
            dsTen.AddRange(new string[] {"An","Bình","Công","Tráng","Lưu","Mẫn","Hùng","bi hùng","tâm","Tâm" });


            int i = dsTen.IndexOf("Hùng"); //6
            int j = dsTen.LastIndexOf("Hùng");//6
            int k = dsTen.IndexOf("hùng");//7

            bool k1 = dsTen.Contains("Tâm");//True
            bool k2 = dsTen.Contains("bi");//False



        }

        protected void btnSapXep_Click(object sender, EventArgs e)
        {
            ArrayList dsTen = new ArrayList();
            dsTen.AddRange(new string[] { "An", "Bình", "Công", "Tráng", "Lưu", "Mẫn", "Hùng", "bi hùng", "tâm", "Tâm" });

            dsTen.Sort();//Tăng dần
            dsTen.Reverse(); //Đảo ngược thứ tự các phẩn tử



        }

        protected void btnDuyet_Click(object sender, EventArgs e)
        {
            ArrayList dsSV = new ArrayList();
            dsSV.Add(new SinhVien("SV01","Nguyễn Hậu",5));
            dsSV.Add(new SinhVien("SV02", "Trần Tình", 6));
            dsSV.Add(new SinhVien("SV03", "Nguyễn Lương", 2));
            dsSV.Add(new SinhVien("SV04", "Hậu Giang",9));


            //Tính tổn điểm của các SV
            //Cách 1: dùng FOR
            double tongDiem = 0;
            for (int i = 0; i < dsSV.Count; i++)
            {
                var sv = (SinhVien)dsSV[i]; //Ép kiểu vể Sinh Viên để tính toán -  Quan trọng
                tongDiem += sv.Diem;
            }

            lblKetQua.Text = "Tổng điểm các sinh viên: " + tongDiem; //Ngầm hiểu là tongDiem.ToString()

            // Cách 2: dùng FOREACH
            double tongDiem2 = 0;
            foreach (SinhVien sv in dsSV)
            {
                tongDiem2 += sv.Diem;
            }
            lblKetQua2.Text = "Tổng kiểm cách thứ 2: " + tongDiem2;

            //Cách thứ 3: TỔNG QUÁT
            double tongDiem3 = 0;

            foreach (object pt in dsSV)
            {
                var sv = (SinhVien)pt;
                tongDiem3 += sv.Diem;
            }
            lblKetQua3.Text = "Tổng kiểm cách thứ 3: " + tongDiem3;

        }

        protected void btnWhile_Click(object sender, EventArgs e)
        {
            ArrayList dsSV = new ArrayList();
            dsSV.Add(new SinhVien("SV01", "Nguyễn Hậu", 5));
            dsSV.Add(new SinhVien("SV02", "Trần Tình", 6));
            dsSV.Add(new SinhVien("SV03", "Nguyễn Lương", 2));
            dsSV.Add(new SinhVien("SV04", "Hậu Giang", 9));

            double tongDiem = 0;
            IEnumerator ds = dsSV.GetEnumerator();
            while (ds.MoveNext())
            {
                SinhVien sv = (SinhVien)ds.Current;
                tongDiem += sv.Diem;
            }
            lblKetqua4.Text = "Tongdiem là: " + tongDiem;
        }
    }
}