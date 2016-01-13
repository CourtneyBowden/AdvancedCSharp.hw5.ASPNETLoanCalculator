<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="hw5.bowden.Help" %>

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
                <td style="text-align: center">This is a help page for a financial calculator application.</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td style="text-align: center"><asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
