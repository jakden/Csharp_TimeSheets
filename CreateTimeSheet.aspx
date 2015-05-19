<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="CreateTimeSheet.aspx.cs" Inherits="CreateTimeSheet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <br /> 
    <center><h1>Defense Civilian Medical Associates</h1></center>
    <div id="DivAddress">
        <table>
            <tr>
                <td>1455 Pennsylvania Avenue</td>
            </tr>
            <tr>
                <td>Suite 400</td>
            </tr>
            <tr>
                <td>Washington, DC 20004</td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>
                    <b>Week Start Date:&nbsp; </b>
                </td>
                <td>
                    <asp:label runat="server" ID="LabelStartDate"></asp:label>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Week End Date:</b>
                </td>
                <td>
                    <asp:label runat="server" ID="LabelEndDate"></asp:label>
                </td>
                <td>
                    <asp:label runat="server" ID="LabelReg1"></asp:label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label runat="server" visible="false" ID="LabelTodayDate"></asp:label>
                </td>
                <td>
                    <asp:label runat="server" visible="false" ID="LabelDayName"></asp:label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:calendar ID="CalendarStartDate" runat="server" 
           >
        </asp:calendar>
    </div>
    <div id="DivContactInfo">
        <table>
        <tr><td></td></tr>
            <tr>
                <td>Office:</td>
                <td>(202) 621-1890</td>
            </tr>
            <tr>
                <td>FAX:</td>
                <td>(202) 459-2213</td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>Contract:</td>
                <td>W91YTZ-08-P-0827</td>
            </tr>
            <tr>
                <td>Duns:</td>
                <td>117786785</td>
            </tr>
            <tr>
                <td>CAGE Code:</td>
                <td>3A1B1</td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
    <table border="5" class="TimeSheetTable">
        <tr style="background-color:Black;color:White;font-weight:bold;text-align:center">
            <td>DAY</td>
            <td>DATE</td>
            <td>IN</td>
            <td>OUT</td>
            <td>IN</td>
            <td>OUT</td>
            <td>REGULAR HOURS</td>
            <td>CALL HOURS</td>
            <td>CALL WEEK</td>
            <td>Site</td>
        </tr>
        <tr>
            <td>
            Monday
            </td>
            <td>
                <asp:Label ID="LabelMonday" Width="75" runat="server" Text=""></asp:Label>
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Monday" Width="65" runat="server" 
                    onselectedindexchanged="DDL_In_Monday_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Monday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Monday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Monday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelMondayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelMondayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Tuesday
            </td>
            <td>
                <asp:Label ID="LabelTuesday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Tuesday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Tuesday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Tuesday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Tuesday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelTuesdayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelTuesdayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Wednesday
            </td>
            <td>
                <asp:Label ID="LabelWednesday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Wednesday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Wednesday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Wednesday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Wednesday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelWednesdayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelWednesdayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Thursday
            </td>
            <td>
                <asp:Label ID="LabelThursday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Thursday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Thursday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Thursday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Thursday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelThursdayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelThursdayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Friday
            </td>
            <td>
                <asp:Label ID="LabelFriday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Friday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Friday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Friday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Friday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelFridayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelFridayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                Saturday
            </td>
            <td>
                <asp:Label ID="LabelSaturday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Saturday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Saturday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Saturday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Saturday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelSaturdayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                <asp:Label ID="LabelSaturdayCALL" runat="server" Text=""></asp:Label>  
            </td>

        </tr>
        <tr>
            <td>
                Sunday
            </td>
            <td>
                <asp:Label ID="LabelSunday" Width="75" runat="server" Text=""></asp:Label>  
            </td>
            <td>
            <asp:DropDownList ID="DDL_In_Sunday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_OutBreak_Sunday" Width="65" runat="server" AutoPostBack="False">
                </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_InBreak_Sunday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
            <asp:DropDownList ID="DDL_Out_Sunday" Width="65" runat="server" AutoPostBack="False">
            </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LabelSundayREG" runat="server" Text=""></asp:Label>  
            </td>
            <td>
                
                <asp:Label ID="LabelSundayCALL" runat="server" Text=""></asp:Label>  
            </td>
        </tr>
        <tr>
            <td>
                LabelHolder
            </td>
            <td>
                </asp:Label><asp:Label ID="LabelCALLhrsBEFORE" runat="server" Text="Label"></asp:Label>  
                <asp:Label ID="LabelCALLhrsAFTER" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
             <td>
                
            </td>
        </tr>
        <tr>
            <td>
        <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" 
            onclick="ButtonCalculate_Click" />
            </td>
        </tr>
    </table>

    <asp:Label ID="LabelErrorMonday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorTuesday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorWednesday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorThursday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorFriday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorSaturday" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="LabelErrorSunday" runat="server" Text="" ForeColor="Red"></asp:Label>

    <br />
    <asp:Label ID="LabelQuerystring1" runat="server" Text=""></asp:Label>
    <asp:Label ID="LabelQuerystring2" runat="server" Text=""></asp:Label>

    <br />
</asp:Content>

