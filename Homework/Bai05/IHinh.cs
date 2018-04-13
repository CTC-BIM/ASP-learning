using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IHinh
/// </summary>
public interface IHinh
{
    string TenHinh { get; }
    double Dientich();
    double ChuVi();
    string XuatThongTin(string Xuongdong = "\r\n");

}