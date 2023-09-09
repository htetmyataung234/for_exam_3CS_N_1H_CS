<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_1(H1).aspx.cs" Inherits="For_Exam.No_1_H1_" %>

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
    <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" 
        ImageUrl="~/images/blue.png" Width="100px" onclick="ImageButton1_Click" />
    <hr />

    <asp:Button ID="btn_Submit" runat="server" Text="Submit" 
        onclick="btn_Submit_Click" />
        <br />

    <asp:Image ID="Image2" runat="server" Height="200px" Width="200px" />

    </form>
</body>
</html>
