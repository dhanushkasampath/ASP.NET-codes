<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewData.WebForm1" %>

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
            <td>Name:</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Gender:</td>
            <td><asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Department:</td>
            <td><asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    
    </div>
        
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="LoadData" />
            
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            
        </p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        
    </form>
</body>
</html>
