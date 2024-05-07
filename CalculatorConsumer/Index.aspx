<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CalculatorConsumer.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Calculator Client"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblNum1" runat="server" Font-Size="Large" Text="Enter Number1 :"></asp:Label>
        <asp:TextBox ID="txtNum1" runat="server" Height="21px" Width="179px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNum2" runat="server" Font-Size="Large" Text="Enter Number2 :"></asp:Label>
        <asp:TextBox ID="txtNum2" runat="server" Height="21px" Width="179px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="29px" OnClick="btnAdd_Click" Text="Add" Width="41px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSub" runat="server" Height="28px" Text="Sub" Width="41px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMul" runat="server" Height="27px" Text="Mul" Width="46px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDiv" runat="server" Height="30px" Text="Div" Width="45px" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblNum3" runat="server" Font-Size="Large" Text="Result :"></asp:Label>
        <asp:TextBox ID="txtResult" runat="server" Font-Size="XX-Large" ForeColor="#FF0066" Height="53px" Width="179px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
