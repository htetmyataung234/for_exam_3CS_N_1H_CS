<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_4_txtfile.aspx.cs" Inherits="Building_ASP.NET_Pages.For_Exam.save" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" autocomplete="off" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" autocomplete="off" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RadioButton ID="m" runat="server" Text="Male" GroupName="aa" />
                    <asp:RadioButton ID="fm" runat="server" Text="Female" GroupName="aa" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /></td>
            </tr>
            <tr>
                <td colspan=2 style="text-align: center;">
                    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
