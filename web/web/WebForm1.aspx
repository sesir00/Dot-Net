<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web.WebForm1" %>

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
            <asp:TextBox ID="pass" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="val2" ControlToValidate="pass" ErrorMessage="fill the password" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="l3" Text="Repassword" runat="server"></asp:Label>
            <asp:TextBox ID="repass" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="val3" ControlToValidate="repass" ErrorMessage="fill the password" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="val4"  ControlToValidate="repass" ControlToCompare="pass" ErrorMessage="Passwrod should be same" ForeColor="Red" runat="server"></asp:CompareValidator>
            <br />
            <asp:Label ID="l4" Text="Gender" runat="server"></asp:Label>
            <asp:RadioButton ID="r1" GroupName="gender" value="male" Text="Male" runat="server" />&nbsp;
            <asp:RadioButton ID="r2" GroupName="gender" value="female" Text="Female" runat="server" />
            <br />
            <asp:label ID="l5" Text="Course" runat="server"></asp:label>
            <asp:CheckBox ID="c1" Text="C" value="c" runat="server" />&nbsp;
            <asp:CheckBox ID="c2" Text="C++" value="c++" runat="server" />&nbsp;
            <asp:CheckBox ID="c3" Text="Java" value="java" runat="server" />
            <br />
            <asp:Label ID="l6" Text="Country" runat="server"></asp:Label>
            <asp:DropDownList ID="country" runat="server">
                <asp:ListItem Value="">Select your country</asp:ListItem>
                <asp:ListItem>Nepal</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>Japan</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="submit" Text="Submit" value="submit" OnClick="btn_sub" runat="server"/>
            <br />
            <asp:Label ID="l7" Text="Result" runat="server"></asp:Label>
            <asp:GridView ID="gv"
    </form>
</body>
</html>
