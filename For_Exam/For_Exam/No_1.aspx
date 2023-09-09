<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_1.aspx.cs" Inherits="For_Exam.No_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="No.1 Image Control Example"></asp:Label>
    </div>
    <!-- we limited height and width to 100 * 100 px because image is just too big -->
    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/blue.png" Height="100px"
        Width="100px" />
    <hr />
    <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
    <br />
    </form>
</body>
</html>
