<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="No_6(H1).aspx.cs" Inherits="For_Exam.No_6_H1_" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Gmail Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="un" placeholder="Enter Username" required autocomplete=off runat="server"></asp:TextBox>
                </td>
            </tr> 
            <tr>
                <td>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="pw" placeholder="Enter Password" required  runat="server" 
                        TextMode="Password"></asp:TextBox>
                </td>
            </tr> 
            <tr>
                <td>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="cpw" placeholder="Enter Password Again" required  
                        runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr> 
            <tr>
            <td colspan=1 style="text-align:center;">
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Register" 
                        onclick="Button1_Click" />
                </td>
                <td colspan=2 style="text-align:center;">
                    <br />
                    <asp:Button ID="btnRandom" runat="server" Text="Random" 
                        onclick="btnRandom_Click" />
                </td>
            </tr> 
            <tr>
                <td colspan=2 style="text-align:center;">
                    <br />
                    <asp:Label ID="msg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="un"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ValidationGroup="login"></asp:RegularExpressionValidator>
        <br />
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="pw" ControlToValidate="cpw" ValidationGroup="login" 
        ></asp:CompareValidator>
    
    </form>
</body>
</html>
