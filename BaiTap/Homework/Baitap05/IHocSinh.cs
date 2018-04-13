using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public interface IHocSinh
    {
        string maSo { get; set; }
        string Hoten { get; set; }
         string Lop { get; set; }

        double DiemTrungBinh();
        string KetQuaHocTap();
        string XepLoaiKhenThuong();

    }
}