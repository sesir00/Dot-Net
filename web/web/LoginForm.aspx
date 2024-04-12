<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="web.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
     <asp:Label ID="l1" Text="Username" runat="server"></asp:Label>
     <asp:TextBox ID="uname" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="val1" ControlToValidate="uname" ErrorMessage="fill the username" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
     <br />
     <asp:Label ID="l2" Text="Password" runat="server"></asp:Label>
     <asp:Textbox ID="pass" TextMode="Password" runat="server"></asp:Textbox>
     <asp:RequiredFieldValidator ID="val2" ControlToValidate="pass" ErrorMessage="fill the password" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
     <br />
     <asp:Button ID="submit" Text="Submit" runat="server" OnClick="log" />
     <br />
     <asp:Label ID="l3" Text="Result" runat="server"></asp:Label>
     <asp:GridView ID="gv" runat="server"></asp:GridView>
 </div>
    </form>
</body>
</html>
