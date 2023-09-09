<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_4.aspx.cs" Inherits="For_Exam.No_4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <table>
            <tr>
                <td>
                    User Name
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdoMale" runat="server" Text="Male" GroupName="gender" />
                </td>
                <td>
                    <asp:RadioButton ID="rdoFemale" runat="server" Text="Female" 
                        GroupName="gender" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dropAddress" runat="server">
                        <asp:ListItem>Yangon</asp:ListItem>
                        <asp:ListItem>Bago</asp:ListItem>
                        <asp:ListItem>Mandalay</asp:ListItem>
                        <asp:ListItem>Moe Nyo</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
            <td colspan = "2" style = "text-align : center;">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                    onclick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
