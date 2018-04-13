using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public class HinhVuong2:IHinh2
    {
        #region Properties

        private string _TenHinh="Hình Vuông";   

        public string TenHinh
        {
            get { return _TenHinh; }
        }

        private double _Canh;

        public double Canh
        {
            get { return _Canh; }
            set
            {
                if (value < 0) throw new Exception("Chiều dài cạnh hình vuông phải > = 0");
                _Canh = value;
            }
        }

        #endregion


        #region Method

        public double DienTich()
        {
            double kq = 0;
            kq = Canh * Canh;
            return kq;
        }

        public double ChuVi()
        {
            double kq = 0;
            kq = 2 * Canh;
            return kq;
        }

        public string XuatThongTin(string phanCach="\r\n")
        {
            string kq = "";
            kq = string.Format(@"{1} có Chiều dài cạnh bằng {2}{0}Diện tích: {3}{0}Chu vi: {4}{0}",
                                phanCach,TenHinh,Canh,DienTich().ToString(),ChuVi().ToString());
            return kq;
        }
        #endregion

        #region Constructor
       

        #endregion
    }
}