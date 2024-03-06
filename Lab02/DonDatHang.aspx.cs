using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class DonDatHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //khoi tao du lieu cho ddlBanh
                ddlBanh.Items.Add(new ListItem("Bánh bò","01"));
                ddlBanh.Items.Add(new ListItem("Bánh mì", "02"));
                ddlBanh.Items.Add(new ListItem("Bánh su que", "03"));
                ddlBanh.Items.Add(new ListItem("Bánh tiêu", "04"));
            }
        }

        protected void btThem_Click(object sender, EventArgs e)
        {
            string data = $"{ddlBanh.SelectedItem.Text} ({txtSoLuong.Text})";
            lstBanh.Items.Add(data);
        }

        protected void btXoa_Click(object sender, EventArgs e)
        {
            //int index = lstBanh.SelectedIndex;
            //lstBanh.Items.RemoveAt(index);
            for (int i = lstBanh.Items.Count - 1; i >= 0; i--)
            {
                if (lstBanh.Items[i].Selected)
                {
                    lstBanh.Items.RemoveAt(i);
                }
            }
        }

        protected void btIn_Click(object sender, EventArgs e)
        {
            string kq="";
            //b1.thu thap thong tin
            kq += "<h2 class='text-center'> HOÁ ĐƠN ĐẶT HÀNG </h2>";
            kq += "<div class='border border-primary p-2'>";
            kq += "Khách hàng: <i>" + txtHoTen.Text + "</i><br>";
            kq += "Địa chỉ: <i>" + txtDiaChi.Text + "</i><br>";
            kq += "Mã số thuế: <i>" + txtMST.Text + "</i><br><br>";

            kq += "<b>Đặt các loại bánh sau:</b>";
            kq += "<table class='table table-bordered'>";
            char[] delim = {'(',')'}; 
            foreach (ListItem item in lstBanh.Items)
            {
                string[] arr = item.Text.Split(delim);
                kq += "<tr>";
                kq += $"<td> {arr[0]} </td> <td> {arr[1]} </td>";
                kq += "</tr>";
            }

            kq += "</table>";
            kq += "</div>";

            //b2.gui thong tin ve client
            lbKetQua.Text = kq;


        }

        public void abc()
        {
            bool checkExist = false;
            char[] delim = { '(', ')' };
            int soLuong;
            //b1: Kiem tra ton tai
            for(int i = 0; i < lstBanh.Items.Count; i++)
            {
                string itemText = lstBanh.Items[i].Text;
                if (itemText.Contains(ddlBanh.SelectedItem.Text))
                {
                    string[] arr = itemText.Split(delim);
                    
                    checkExist = true;
                }
            }
            //b2
            if (!checkExist)
            {

            }
        }
    }
}