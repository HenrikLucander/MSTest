<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="Calculator.Web.CalculatorPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator Application</title>
</head>
<body style="font-family: Arial">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Numerator</td>
                <td>
                    <asp:TextBox ID="txtNumerator" runat="server" Width="50px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Denominator</td>
                <td>
                    <asp:TextBox ID="txtDenominator" runat="server" Width="50px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Result</td>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>