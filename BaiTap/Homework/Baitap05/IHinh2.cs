using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public interface IHinh2
    {
        string TenHinh { get; }

        double DienTich();
        double ChuVi();
        string XuatThongTin(string phanCach="\r\n");
    }
}