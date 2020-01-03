using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebsiteTinTuc.Presentation.NguoiDung
{
    public partial class BinhLuann : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtYK_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            if(Session["TaiKhoan"]!=null)
            {
                string ten = Session["TaiKhoan"].ToString();
                string maND = Session["MaNguoiDung"].ToString();
                string day = DateTime.Now.Day.ToString();
                string month = DateTime.Now.Month.ToString();
                string year = DateTime.Now.Year.ToString();
                try
                {
                    SqlConnection con = new SqlConnection(XLDL.strCon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = @"insert into BinhLuan(MaBinhLuan,NoiDung,Ngay,MaTin,MaNguoiDung)
                values(@MaBinhLuan,@NoiDung,@Ngay,@MaTin,@MaNguoiDung)";
                    cmd.Parameters.Add("@MaNguoiDung", SqlDbType.Int);
                    cmd.Parameters["@MaNguoiDung"].Value = maND;
                    cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar, 1000);
                    cmd.Parameters["@NoiDung"].Value = txtYK.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    Response.Write("<script>alert('Gửi thành công!')</script>");
                }
                catch
                {
                    Response.Write("<script>alert('Gửi thất bại!')</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('Bạn chưa đăng nhập! Vui lòng đăng nhập trước khi sử dụng chức năng này!!')</script>");
            }
        }

        protected void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtYK.Text = null;
        }
    }
}