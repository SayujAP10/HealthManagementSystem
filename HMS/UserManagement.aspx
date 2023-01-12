<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="HMS.UserManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 615px;
        }
        .auto-style4 {
            height: 26px;
            width: 615px;
        }
        .auto-style5 {
            width: 378px;
        }
        .auto-style6 {
            height: 26px;
            width: 378px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>Username</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" TextMode="Email" Width="292px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Username"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="22px" TextMode="Password" Width="292px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Pasword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Login" Width="102px" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
