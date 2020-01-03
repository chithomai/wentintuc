<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/NguoiDung/GiaoDienNguoiDung.Master" AutoEventWireup="true" CodeBehind="BinhLuan.aspx.cs" Inherits="WebsiteTinTuc.Presentation.NguoiDung.BinhLuann" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        div#YKH{
            color:snow;
        }
        div#YKH>fieldset{
            border:10px;
            margin-left:150px;
            width:502px;
            text-align:center;
        }
        .box{
            
            height:200px;
            width:700px;
            background-color:#20B2AA;
            border:none;
            color:snow;
        }
        .nut{
            height: 30px;
            border-radius:7px;
            width:60px;
        }
        .auto-style1 {
            border-radius: 7px;
        }
        .auto-style2 {
            border-radius: 7px;
            margin-left: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="YKH">      
        <h1>ĐÓNG GÓP Ý KIẾN CỦA BẠN</h1>
        <fieldset>
            <asp:TextBox CssClass="box" ID="txtYK" runat="server" Text="Nhập nội dung!" TextMode="MultiLine" OnTextChanged="txtYK_TextChanged"></asp:TextBox>
            <br />
            <asp:Button CssClass="auto-style2" ID="btnGui" runat="server" Text="Gửi" OnClick="btnGui_Click" Width="63px" />
            <asp:Button CssClass="auto-style1" ID="btnNhapLai" runat="server" Text="Nhập lại" OnClick="btnNhapLai_Click" Width="75px" />
        </fieldset>
    </div>
</asp:Content>
