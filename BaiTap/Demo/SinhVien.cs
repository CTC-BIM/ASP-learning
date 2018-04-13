using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Demo
{
    public class SinhVien
    {

        #region Properties

        private string _MaSo;
        public string MaSo
        {
            get { return _MaSo; }
            set { _MaSo = value; }
        }

        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }


        private double _Diem;

        public double Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
        }

        #endregion


        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public SinhVien() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maSo"></param>
        /// <param name="hoTen"></param>
        public SinhVien(string maSo, string hoTen)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
        }

        public override int GetHashCode()
        {
            return MaSo.GetHashCode();
        }

        public SinhVien(string maSo, string hoTen, double diem)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
            this.Diem = diem;
        }
        #endregion



    }
}