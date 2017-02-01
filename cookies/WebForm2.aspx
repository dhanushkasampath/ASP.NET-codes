<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SendData.WebForm2" %>

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
                <h2>Webform2</h2>
                </td>
             </tr>

            <tr>
                <td>Name: </td>
                <td><asp:Label ID="lblName" runat="server" Text=""></asp:Label></td>
                
            </tr>
                
            <tr>
                
                <td>Email: </td>
                <td><asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></td>
               
            </tr>
            

        </table>
    </div>
    </form>
</body>
</html>
