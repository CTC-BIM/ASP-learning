using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Buoi 10 -------------------------------------
using System.Collections;
using System.Text;

namespace BaiTap.Demo.Buoi_10
{
    public partial class EXCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHashtable_Click(object sender, EventArgs e)
        {
            Hashtable dsThang = new Hashtable();
            dsThang.Add(1, "Tháng Giêng");//Thêm vào cuối danh sách
            dsThang.Add(2, "Tháng Hai");

            dsThang[1] = "Tháng một";//Thêm vào thứ tự số 1, ghi đè lên dữ liệu cũ
            dsThang[3] = "Tháng ba";


            string t2 = dsThang[2].ToString();//ép về string; có thể dùng 'as string'
            StringBuilder sb = new StringBuilder();

            foreach (DictionaryEntry pt in dsThang)
            {
                sb.AppendFormat("{0}-{1}<br/>", pt.Key, pt.Value);
            }
            lblKetQUA.Text = sb.ToString();
        }

        protected void btnSortList_Click(object sender, EventArgs e)
        {
            SortedList dsThang = new SortedList(); //giống Hashtable
            dsThang.Add(1, "Tháng Giêng");//Thêm vào cuối danh sách
            dsThang.Add(3, "Tháng ba");
            dsThang.Add(2, "Tháng Hai");

            string t2 = dsThang[2].ToString();//ép về string; có thể dùng 'as string'

            string k1 = (string)dsThang.GetByIndex(2);//"Tháng 3"
            int k2 = (int)dsThang.GetKey(2);//"==3"

            StringBuilder sb = new StringBuilder();

            foreach (DictionaryEntry pt in dsThang)
            {
                sb.AppendFormat("{0}-{1}<br/>", pt.Key, pt.Value);
            }
            lblKetQUA.Text = sb.ToString();
        }
    }
}