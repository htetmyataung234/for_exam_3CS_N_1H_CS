<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No3.aspx.cs" Inherits="For_Exam.No3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Dance</asp:ListItem>
            <asp:ListItem>A ka</asp:ListItem>
            <asp:ListItem>Football</asp:ListItem>
            <asp:ListItem>Basketball</asp:ListItem>
            <asp:ListItem>Swimming</asp:ListItem>
            <asp:ListItem>Gaming</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnAdd" runat="server" Text="&gt;&gt;" onclick="btnAdd_Click" />
    
    </div>
    <br />
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <br />
    <asp:Button ID="btnFill" runat="server" Text="Fill" onclick="btnFill_Click" />
    <asp:Button ID="btnSort" runat="server" Text="Sort" onclick="btnSort_Click" />
    <asp:Button ID="btnClear" runat="server" Text="Clear" 
        onclick="btnClear_Click" />
    <asp:Button ID="btnExit" runat="server" Text="Exit" onclick="btnExit_Click" 
        style="margin-right: 1px" />
        <br />
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
