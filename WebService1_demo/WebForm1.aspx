<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebService1_demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
        <form id="form1" runat="server">
        <table style="font-family:Arial">
            <tr>
                <td>
                    <b>appr</b>
                </td>
                <td>
                    <asp:TextBox ID="txtAppr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>start date</b>
                </td>
                <td>
                    <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>end date</b>
                </td>
                <td>
                    <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>bfy</b>
                </td>
                <td>
                    <asp:TextBox ID="txtBfy" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    <div style="height:27px; width: 67px; margin-left: 184px;">

        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />

    </div>
    <div>Result:</div>
    <asp:GridView ID="ApprDivSummaryGridView" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        </form>
    </body>
</html>
