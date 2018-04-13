using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public class HocSinhLop1:IHocSinh
    {
        #region Propperties

        private string _maSo;
        public string maSo
        {
            get { return _maSo; }
            set { _maSo = value; }
        }

        private string _Hoten;

        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }
        private string _Lop;

        public string Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }

        #region New Properties

        private double _Toan;
        public double Toan
        {
            get { return _Toan; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _Toan = value;
            }
        }

        private double _TiengViet;
        public double TiengViet
        {
            get { return _TiengViet; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _TiengViet = value;
            }
        }
        private double _TapViet;
        public double TapViet
        {
            get { return _TapViet; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _TapViet = value;
            }
        }

        #endregion


        #endregion

        #region Method

        public double DiemTrungBinh()
        {
            double kq = 0;

            return kq;
        }

        public string KetQuaHocTap()
        {
            string kq = "";

            return kq;
        }

        public  string XepLoaiKhenThuong()
        {
            string kq = "";

            return kq;
        }



        #endregion


    }
}