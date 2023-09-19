<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_8.aspx.cs" Inherits="For_Exam.No_8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
             DataTextField="Name" DataValueField="Price" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Selected="True" Value="1500">Cola</asp:ListItem>
            <asp:ListItem Value="1000">Pepsi</asp:ListItem>
        </asp:DropDownList>
    </div>
    <asp:Label ID="lblPrice" runat="server" 
        Text="Select something and enter Quantity in int^^"></asp:Label>
    &nbsp;
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="txtQuantity" runat="server" AutoPostBack="True" 
                    ontextchanged="txtQuantity_TextChanged">1</asp:TextBox>
            </td>
        </tr>
        <tr>
             <td>
                <asp:Label ID="Label3" runat="server" Text="Total"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="txtTotal" runat="server" ReadOnly = "true"></asp:TextBox>
            </td>
        </tr>
    </table>
    
 
    <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
    
 
    </form>
</body>
</html>
