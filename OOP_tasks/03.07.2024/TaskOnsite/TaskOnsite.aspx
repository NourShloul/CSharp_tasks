<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskOnsite.aspx.cs" Inherits="TaskOnsite.TaskOnsite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <p>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="Name" runat="server" OnTextChanged="TextBox3_TextChanged" Width="168px"></asp:TextBox>

            </p>
        
        <p>
            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="Email" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="ID: "></asp:Label>
            <asp:TextBox ID="Id" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Gender: "></asp:Label>
            &nbsp;<asp:RadioButton ID="RadioOption1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male " GroupName="gender" />
&nbsp;
            <asp:RadioButton ID="RadioOption2" runat="server" Text="Female " GroupName="gender" OnCheckedChanged="RadioButton2_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Courses: "></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C " />
            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="C# " />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Description: "></asp:Label>
            </p>
         <p>
     <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="2" OnTextChanged="TextBox4_TextChanged" Text=""></textarea></p>
        <p>
            <asp:Button ID="Submit" runat="server" Text="Submit " onclick="Submit_Click"/>
        </p>
            
            </div>
        <div style="border:solid">
        <h2>
    Personal Info:</h2>
   <div>
       Name:
       <asp:Label ID="Label7" runat="server" Text="Name"></asp:Label>

   </div>
    
   
        <p>
            Email:
       <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            ID:
       <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Gender:
       <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Courses:
       <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Description:
       <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>

        </p>
            </div>
         </form>
       
   
</body>
</html>
