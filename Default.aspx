<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Label1
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Label2
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Label3
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                LabelReg
            </td>
            <td>
                <asp:Label ID="LabelReg" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                LabelComp
            </td>
            <td>
                <asp:Label ID="LabelComp" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                LabelHolder
            </td>
            <td>
                <asp:Label ID="LabelHolder" runat="server" Text="Label"></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
        <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" 
            onclick="ButtonCalculate_Click" />
            </td>
        </tr>
    </table>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" 
        EmptyDataText="There are no data records to display." 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Week_ID" HeaderText="Week_ID" 
                SortExpression="Week_ID" />
            <asp:BoundField DataField="Monday_In" HeaderText="Monday_In" 
                SortExpression="Monday_In" />
            <asp:BoundField DataField="Monday_Out_Break" HeaderText="Monday_Out_Break" 
                SortExpression="Monday_Out_Break" />
            <asp:BoundField DataField="Monday_In_Break" HeaderText="Monday_In_Break" 
                SortExpression="Monday_In_Break" />
            <asp:BoundField DataField="Monday_Out" HeaderText="Monday_Out" 
                SortExpression="Monday_Out" />
            <asp:BoundField DataField="Tuesday_In" HeaderText="Tuesday_In" 
                SortExpression="Tuesday_In" />
            <asp:BoundField DataField="Tuesday_Out_Break" HeaderText="Tuesday_Out_Break" 
                SortExpression="Tuesday_Out_Break" />
            <asp:BoundField DataField="Tuesday_In_Break" HeaderText="Tuesday_In_Break" 
                SortExpression="Tuesday_In_Break" />
            <asp:BoundField DataField="Tuesday_Out" HeaderText="Tuesday_Out" 
                SortExpression="Tuesday_Out" />
            <asp:BoundField DataField="Wednesday_In" HeaderText="Wednesday_In" 
                SortExpression="Wednesday_In" />
            <asp:BoundField DataField="Wednesday_Out_Break" 
                HeaderText="Wednesday_Out_Break" SortExpression="Wednesday_Out_Break" />
            <asp:BoundField DataField="Wednesday_In_Break" HeaderText="Wednesday_In_Break" 
                SortExpression="Wednesday_In_Break" />
            <asp:BoundField DataField="Wednesday_Out" HeaderText="Wednesday_Out" 
                SortExpression="Wednesday_Out" />
            <asp:BoundField DataField="Thursday_In" HeaderText="Thursday_In" 
                SortExpression="Thursday_In" />
            <asp:BoundField DataField="Thursday_Out_Break" HeaderText="Thursday_Out_Break" 
                SortExpression="Thursday_Out_Break" />
            <asp:BoundField DataField="Thursday_In_Break" HeaderText="Thursday_In_Break" 
                SortExpression="Thursday_In_Break" />
            <asp:BoundField DataField="Thursday_Out" HeaderText="Thursday_Out" 
                SortExpression="Thursday_Out" />
            <asp:BoundField DataField="Friday_In" HeaderText="Friday_In" 
                SortExpression="Friday_In" />
            <asp:BoundField DataField="Friday_Out_Break" HeaderText="Friday_Out_Break" 
                SortExpression="Friday_Out_Break" />
            <asp:BoundField DataField="Friday_In_Break" HeaderText="Friday_In_Break" 
                SortExpression="Friday_In_Break" />
            <asp:BoundField DataField="Friday_Out" HeaderText="Friday_Out" 
                SortExpression="Friday_Out" />
            <asp:BoundField DataField="Saturday_In" HeaderText="Saturday_In" 
                SortExpression="Saturday_In" />
            <asp:BoundField DataField="Saturday_Out_Break" HeaderText="Saturday_Out_Break" 
                SortExpression="Saturday_Out_Break" />
            <asp:BoundField DataField="Saturday_In_Break" HeaderText="Saturday_In_Break" 
                SortExpression="Saturday_In_Break" />
            <asp:BoundField DataField="Saturday_Out" HeaderText="Saturday_Out" 
                SortExpression="Saturday_Out" />
            <asp:BoundField DataField="Sunday_In" HeaderText="Sunday_In" 
                SortExpression="Sunday_In" />
            <asp:BoundField DataField="Sunday_Out_Break" HeaderText="Sunday_Out_Break" 
                SortExpression="Sunday_Out_Break" />
            <asp:BoundField DataField="Sunday_In_Break" HeaderText="Sunday_In_Break" 
                SortExpression="Sunday_In_Break" />
            <asp:BoundField DataField="Sunday_Out" HeaderText="Sunday_Out" 
                SortExpression="Sunday_Out" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DCMAConnectionString1 %>" 
        ProviderName="<%$ ConnectionStrings:DCMAConnectionString1.ProviderName %>" 
        
        SelectCommand="SELECT [Week_ID], [Monday_In], [Monday_Out_Break], [Monday_In_Break], [Monday_Out], [Tuesday_In], [Tuesday_Out_Break], [Tuesday_In_Break], [Tuesday_Out], [Wednesday_In], [Wednesday_Out_Break], [Wednesday_In_Break], [Wednesday_Out], [Thursday_In], [Thursday_Out_Break], [Thursday_In_Break], [Thursday_Out], [Friday_In], [Friday_Out_Break], [Friday_In_Break], [Friday_Out], [Saturday_In], [Saturday_Out_Break], [Saturday_In_Break], [Saturday_Out], [Sunday_In], [Sunday_Out_Break], [Sunday_In_Break], [Sunday_Out] FROM [Week]" 
        onselecting="SqlDataSource1_Selecting">
    </asp:SqlDataSource>
    </form>
</body>
</html>
