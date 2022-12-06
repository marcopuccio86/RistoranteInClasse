<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistraUtente.aspx.cs" Inherits="RistoranteInClasse.RegistraUtente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="red"
                runat="server" ErrorMessage="Username obbligatorio" ControlToValidate="txtUsername" 
                EnableClientScript="false"></asp:RequiredFieldValidator> <br />
            
            Password: <asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox> <br />
            Conferma Password: <asp:TextBox TextMode="Password" ID="txtConfermaPassword" runat="server"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtConfermaPassword" ControlToCompare="txtPassword" 
                runat="server" ForeColor="red"  EnableClientScript="false"
                ErrorMessage="Le password non corrispondono"></asp:CompareValidator>
            
            <br />
            Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtEmail"  ForeColor="red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" EnableClientScript="false"
                runat="server" ErrorMessage="Inserire una mail corretta"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Registra" />
        </div>
    </form>
</body>
</html>
