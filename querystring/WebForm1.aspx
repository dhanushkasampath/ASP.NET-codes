<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SendData.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">
                <h2>Webform1</h2>
                </td>
             </tr>

            <tr>
                <td>Name: </td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
                
            <tr>
                
                <td>Email: </td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr >
                
                <td colspan="2"><asp:Button ID="btnGoTo" runat="server" Text="Go to webform 2" OnClick="btnGoTo_Click" /></td>
                
            </tr>

        </table>
    
    </div>
        
    </form>
</body>
</html>
