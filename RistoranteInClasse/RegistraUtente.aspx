<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistraUtente.aspx.cs" Inherits="RistoranteInClasse.RegistraUtente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Si sono verificati i seguenti errori:"
                CssClass="alert alert-danger"  />

            Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox> 
            
            Password: <asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox> <br />
            Conferma Password: <asp:TextBox TextMode="Password" ID="txtConfermaPassword" runat="server"></asp:TextBox> 
        
            <br />
            Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Registra" OnClick="Button1_Click"/>

            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" ForeColor="red" 
                runat="server" ErrorMessage="Username obbligatorio" ControlToValidate="txtUsername" 
               ></asp:RequiredFieldValidator> <br />

               <asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtConfermaPassword" ControlToCompare="txtPassword"  
                runat="server" ForeColor="red" 
                ErrorMessage="Le password non corrispondono"></asp:CompareValidator>  <br />

             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtEmail"  ForeColor="red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                runat="server" ErrorMessage="Inserire una mail corretta"></asp:RegularExpressionValidator>
            <br />
        </div>
    </form>
</body>
</html>
