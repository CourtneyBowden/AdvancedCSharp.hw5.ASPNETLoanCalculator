<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterestCalculator.aspx.cs" Inherits="hw5.bowden.InterestCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Loan Amount</td>
                <td><asp:TextBox ID="txtLoanAmount" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Loan Term In Years</td>
                <td><asp:TextBox ID="txtLoanTerm" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Interest Rate %</td>
                <td><asp:TextBox ID="txtInterestRate" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" /></td>
                <td><asp:Button ID="btnHelp" runat="server" Text="Help" OnClick="btnHelp_Click" /></td>
            </tr>
            <tr>
                <td>Monthly Payment</td>
                <td><asp:TextBox ID="txtMonthlyPayment" runat="server" ></asp:TextBox></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

