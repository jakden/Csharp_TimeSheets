<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
    <tr>
        <td>
            Login</td>
        <td>
            <asp:textbox ID="TextboxUsername" runat="server"></asp:textbox>
            <asp:Label ID="LabelNoUsername" runat="server" Text="" ></asp:Label>
            <asp:Label ID="LabelQuerystring" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Password
            </td>
        <td>
            <asp:textbox ID="TextboxPassword" runat="server"></asp:textbox>
            <asp:Label ID="LabelNoPassword" runat="server" Text="" ></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" 
                onclick="ButtonLogin_Click" />
            <asp:Label ID="LabelServerError" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LabelNewUsername" runat="server" Text="Create a Username"></asp:Label> 
        </td>
        <td>
            <asp:TextBox ID="TextBoxNewUsername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LabelNewPassword" runat="server" Text="Create a Password"></asp:Label> 
        </td>
        <td>
            <asp:TextBox ID="TextBoxNewPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LabelUsername" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Button ID="ButtonCreateUser" runat="server" Text="Create User" 
                onclick="ButtonCreateUser_Click" /> 
            <asp:Label ID="LabelDuplicateUser" runat="server" Text=""></asp:Label>
            
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>

</asp:Content>

