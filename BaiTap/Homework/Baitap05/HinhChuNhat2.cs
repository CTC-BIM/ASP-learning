using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public class HinhChuNhat2:IHinh2
    {
        #region Properties

        private string _TenHinh="Hình Chữ Nhật";   

        public string TenHinh
        {
            get { return _TenHinh; }
        }

        private double _ChieuDai;

        public double ChieuDai
        {
            get { return _ChieuDai; }
            set
            {
                if (value < 0) throw new Exception("Chiều dài phải > = 0");
                _ChieuDai = value;
            }
        }

        private double _ChieuRong;
        public double ChieuRong
        {
            get { return _ChieuRong; }
            set
            {
                if (value < 0) throw new Exception("Chiều rộng phải > = 0");
                _ChieuRong = value;
            }
        }
        #endregion


        #region Method

        public double DienTich()
        {
            double kq = 0;
            kq = ChieuDai * ChieuRong;
            return kq;
        }

        public double ChuVi()
        {
            double kq = 0;
            kq = 2 * (ChieuDai+ChieuRong);
            return kq;
        }

        public string XuatThongTin(string phanCach="\r\n")
        {
            string kq = "";
            kq = string.Format(@"{1} có (Dài: {2} x Rộng: {3}){0}Diện tích: {3}{0}Chu vi: {4}{0}",
                                phanCach,TenHinh,ChieuDai,ChieuRong,DienTich().ToString(),ChuVi().ToString());
            return kq;
        }
        #endregion

        #region Constructor
       

        #endregion
    }
}