<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/NguoiDung/GiaoDienNguoiDung.Master" AutoEventWireup="true" CodeBehind="ChiTietTin.aspx.cs" Inherits="WebsiteTinTuc.Presentation.NguoiDung.ChiTietTin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" ID="rpt" OnItemCommand="rpt_ItemCommand">
        <ItemTemplate>
            <div style="clear:both"></div>
            <h3 style="width:700px; margin-top:10px;">
                <asp:HyperLink Font-Underline="false" ID="hplTK" runat="server" ForeColor="#006087" NavigateUrl='<%#"ChiTietTin.aspx?MaTin=" + Eval("MaTin") %>' Text='<%# Eval("TieuDe") %>'>'></asp:HyperLink>
            </h3><br />
            <p style="width:700px; margin-bottom:5px;">
                <%#Eval("TomTat") %>
            </p>
            <h4 style="font-size:10px;">
                <%#Eval("NgayDang") %>
            </h4><br />
            <p align="center" style="width:700px;"><img src='/Presentation/NguoiDung/Images/<%# Eval("HinhAnh") %>' style="margin-bottom: 7px;" /></p>
            <p style="width:700px;"><%#Eval("NoiDung") %></p><br />
            
            <h2 style="color:#ff006e"><a href="BinhLuan.aspx">NHẤN VÀO ĐÂY ĐỂ BÌNH LUẬN</a></h2>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
