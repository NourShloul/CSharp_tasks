<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task2_3_7.aspx.cs" Inherits="task2_3_7_2024.task2_3_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div >
               Result: <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
            </div>

             <p>
                <asp:Label ID="Label2" runat="server" Text="num1"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </p>
        <p>
                <asp:Label ID="Label3" runat="server" Text="num2"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </p>
        <p>
                <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="*" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="-" OnClick="Button3_Click" />
                </p>
        </div>
    </form>
</body>
</html>
