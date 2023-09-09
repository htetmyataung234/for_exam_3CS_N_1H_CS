<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_2.aspx.cs" Inherits="For_Exam.No_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;">
        <asp:Label ID="No2_List_Box_Control" runat="server" Text="Label"></asp:Label>
        <hr />
    </div>
    <table>
        <tr>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" Height="200px">
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2</asp:ListItem>
                    <asp:ListItem>Item3</asp:ListItem>
                </asp:ListBox>
            </td>
            <td>
                <asp:Button ID="btnSendR" runat="server" Text=">" Height="50px" Width="40px" 
                    onclick="btnSendR_Click" />
                <br />
                <asp:Button ID="btnSendL" runat="server" Text="<" Height="50px" Width="40px" 
                    onclick="btnSendL_Click" />
                <br />
                <asp:Button ID="btnSendAllR" runat="server" Text=">>" Height="50px" 
                    Width="40px" onclick="btnSendAllR_Click" />
                <br />
                <asp:Button ID="btnSendAllL" runat="server" Text="<<" Height="50px" 
                    Width="40px" onclick="btnSendAllL_Click" />
            </td>
            <td>
                <asp:ListBox ID="ListBox2" runat="server" Height="200px" 
                    onselectedindexchanged="ListBox2_SelectedIndexChanged" Width="88px"></asp:ListBox>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
