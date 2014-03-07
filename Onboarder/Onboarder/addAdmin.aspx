<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addAdmin.aspx.cs" Inherits="Onboarder.addAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title></title>

</head>

<body>

    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="5" cellspacing="2">
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_empid_admin" runat="server" Text="Employee Id.: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_empid_admin" runat="server" MaxLength="7" Width="100px" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_email_admin" runat="server" Text="E-mail Address: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_email_admin" runat="server" MaxLength="60" TextMode="Email" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_password_admin" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_password_admin" runat="server" MaxLength="60" TextMode="Password" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_reenter_password_admin" runat="server" Text="Re-enter Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_reenter_password_admin" runat="server" MaxLength="60" TextMode="Password" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_firstname_admin" runat="server" Text="First Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_firstname_admin" runat="server" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_lastname_admin" runat="server" Text="Last Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_lastname_admin" runat="server" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_drpdwn_account_admin" runat="server" Text="Account: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpdwn_account_admin" runat="server">
                        <asp:ListItem Value="GERE">GE Real Estate</asp:ListItem>
                        <asp:ListItem Value="GERAIL">GE Rail</asp:ListItem>
                        <asp:ListItem Value="GEHEALTH">GE Healthcare</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_txt_datecreated_admin" runat="server" Text="Today's Date: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_datecreated_admin" runat="server" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_drpdwn_role_admin" runat="server" Text="Role: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpdwn_role_admin" runat="server">
                        <asp:ListItem Value="DEVELOPER">Developer</asp:ListItem>
                        <asp:ListItem Value="PROJECTLEAD">Project Leader</asp:ListItem>
                        <asp:ListItem Value="PROJECTMANAGER">Project Manager</asp:ListItem>
                        <asp:ListItem Value="ACCOUNTMANAGER">Account Manager</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="lbl_drpdwn_project_admin" runat="server" Text="Project: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpdwn_project_admin" runat="server">
                        <asp:ListItem Value="EGR">eGlobal Reporting</asp:ListItem>
                        <asp:ListItem Value="ATLAS">Atlas</asp:ListItem>
                        <asp:ListItem Value="HFS">HFS</asp:ListItem>
                        <asp:ListItem Value="COGNOS">COGNOS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right">
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btn_submit" runat="server" Text="Submit Form" OnClick="Add_Admin" />
                </td>
            </tr>
        </table>
    </div>
    </form>

</body>

</html>
