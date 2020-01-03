using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteTinTuc.BusinessLogicLayer;
using WebsiteTinTuc.DataAccessLayer;
using WebsiteTinTuc.Entities;



namespace WebsiteTinTuc.Presentation.NguoiDung
{
    public partial class GiaoDienNguoiDung1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Tin> ds = new List<Tin>();
            TinBLL tbll = new TinBLL();
            ds = tbll.LayMaLoaiTin2("LT04");
            this.rpt.DataSource = ds;
            rpt.DataBind();

            List<Tin> ds9 = new List<Tin>();
            TinBLL tbll9 = new TinBLL();
            ds9 = tbll9.LayMaLoaiTin2benphai("LT05");
            this.Repeater9.DataSource = ds9;
            Repeater9.DataBind();

            List<Tin> ds1 = new List<Tin>();
            TinBLL tbll1 = new TinBLL();
            ds1 = tbll.LayMaLoaiTin1("LT01");
            this.Repeater1.DataSource = ds1;
            Repeater1.DataBind();

            List<Tin> ds10 = new List<Tin>();
            TinBLL tbll10 = new TinBLL();
            ds10 = tbll10.LayMaLoaiTin1benphai("LT02");
            this.Repeater10.DataSource = ds10;
            Repeater10.DataBind();

            List<Tin> ds2 = new List<Tin>();
            TinBLL tbll2 = new TinBLL();
            ds2 = tbll.LayMaLoaiTin3("LT07");
            this.Repeater2.DataSource = ds2;
            Repeater2.DataBind();

            List<Tin> ds11 = new List<Tin>();
            TinBLL tbll11 = new TinBLL();
            ds11 = tbll11.LayMaLoaiTin3benphai("LT08");
            this.Repeater11.DataSource = ds11;
            Repeater11.DataBind();

            List<Tin> ds3 = new List<Tin>();
            TinBLL tbll3 = new TinBLL();
            ds3 = tbll.LayMaLoaiTin4("LT11");
            this.Repeater3.DataSource = ds3;
            Repeater3.DataBind();

            List<Tin> ds12 = new List<Tin>();
            TinBLL tbll12 = new TinBLL();
            ds12 = tbll12.LayMaLoaiTin4benphai("LT12");
            this.Repeater12.DataSource = ds12;
            Repeater12.DataBind();

            List<Tin> ds4 = new List<Tin>();
            TinBLL tbll4 = new TinBLL();
            ds4 = tbll.LayMaLoaiTin5("LT13");
            this.Repeater4.DataSource = ds4;
            Repeater4.DataBind();

            List<Tin> ds13 = new List<Tin>();
            TinBLL tbll13 = new TinBLL();
            ds13 = tbll13.LayMaLoaiTin5benphai("LT13");
            this.Repeater13.DataSource = ds13;
            Repeater13.DataBind();

            List<Tin> ds5 = new List<Tin>();
            TinBLL tbll5 = new TinBLL();
            ds5 = tbll.LayMaLoaiTin6("LT14");
            this.Repeater5.DataSource = ds5;
            Repeater5.DataBind();

            List<Tin> ds14 = new List<Tin>();
            TinBLL tbll14 = new TinBLL();
            ds14 = tbll13.LayMaLoaiTin6benphai("LT15");
            this.Repeater14.DataSource = ds14;
            Repeater14.DataBind();

            //
  
        }
    }
}