using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebsiteTinTuc.Presentation.NguoiDung
{
    public partial class GiaoDienNguoiDung : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["TaiKhoan"]!=null)
            {
                aDangNhap.Visible = false;
                aDangKy.Visible = false;
                lbTaiKhoan.Visible = true;
                lbTaiKhoan.Text= "Xin chào: " + Session["TaiKhoan"].ToString();
                lbtDangXuat.Visible = true;
            }
            else
            {
                lbTaiKhoan.Text = "";
                lbTaiKhoan.Visible = false;
                lbtDangXuat.Visible = false;
                aDangNhap.Visible = true;
                aDangKy.Visible = true;
            }
        }

        protected void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Bạn chưa nhập nội dung!" + "')</script>");
                txtTK.Focus();
            }
            else
            {
                string moithu = txtTK.Text;
                Response.Redirect("TimKiem.aspx?moithu=" + moithu);
            }
        }

        protected void Repeater8_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void lbtDangXuat_Click(object sender, EventArgs e)
        {

            Session["TaiKhoan"] = null;
            Response.Write("<script>alert('Đăng xuất thành công'); window.location.replace('/Presentation/NguoiDung/TrangChu.aspx');</script>");
        }
    }
}