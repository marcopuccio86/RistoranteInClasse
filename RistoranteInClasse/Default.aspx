<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RistoranteInClasse.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>
        #CheckBoxListAggiunzioni label{
            margin:10px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1>Scegli il tuo menu!</h1>
                        <h2>Le nostre pizze</h2>
                        <hr />
                        <asp:DropDownList ID="ElencoPizze" CssClass="form-control" 
                            runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <hr />

                <div class="row">
                    <div class="text-center">
                        <h4>Aggiunzioni</h4>
                        <asp:CheckBoxList ID="CheckBoxListAggiunzioni" RepeatLayout="Flow"
                            CssClass="form-control" RepeatColumns="3" runat="server">
                            <asp:ListItem Text="Mozz. Bufala (+ 3,00)" Value="3"></asp:ListItem>
                              <asp:ListItem Text="Pros. Cott (+ 3,00)" Value="3"></asp:ListItem> 
                            <asp:ListItem Text="Funghi (+ 2,00)" Value="2"></asp:ListItem> 
                              <asp:ListItem Text="Bacon (+ 2,00)" Value="2"></asp:ListItem> 
                              <asp:ListItem Text="Salame piccante (+ 3,00)" Value="3"></asp:ListItem> 
                              <asp:ListItem Text="Speck (+ 3,00)" Value="3"></asp:ListItem> 
                        </asp:CheckBoxList>
                    </div>
                </div>
                <hr />
                <div class="row text-center">
                    <asp:Button ID="AggiungiPiatto" runat="server" CssClass="btn btn-info"
                        Text="Aggiungi Piatto" 
                        OnClick="AggiungiPiatto_Click" />
                </div>
                <hr />

                <div class="row text-center">
                    <asp:Button ID="CalcolaConto" runat="server" CssClass="btn btn-success"
                        Text="Concludi ordine" 
                        OnClick="CalcolaConto_Click" />
                </div>

                <hr />
                <div id="RiepilogoConto" class="alert alert-info" runat="server">
                    <asp:Label ID="ElencoOrdinazioni" runat="server" Text=""></asp:Label>
                    <hr />
                      <asp:Label ID="TotaleConto" Font-Bold="true" Font-Size="20px" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div> 
    </form>
</body>
</html>
