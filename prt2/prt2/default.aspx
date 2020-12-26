<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="prt2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Hello C# 웹프로그래밍</h2>
            <p>C# Studio<asp:Image ID="Image1" runat="server" ImageUrl="~/images/옷 브랜드.png" /></p>
        </div>
        <!--서버 동작 코드 asp:-->
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:Button ID="btn1" runat="server" Text="다음 페이지" Height="65px" OnClick="btn1_Click"/>
        <a href="supPage1. aspx">다음 페이지로</a>
    </form>
</body>
</html>
