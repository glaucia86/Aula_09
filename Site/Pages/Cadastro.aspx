<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Cadastro de Pessoa</h3>
        <br />
        
        Nome da Pessoa:<br />
        <asp:TextBox ID="txtNome" runat="server" Width="60%"/>
        <br /><br />
        
        Email:<br />
        <asp:TextBox ID="txtEmail" runat="server" Width="40%"/>
        <br /><br />
        
        Logradouro:<br />
        <asp:TextBox ID="txtLogradouro" runat="server" Width="75%"/>
        <br /><br />
        
        Cidade:<br />
        <asp:TextBox ID="txtCidade" runat="server" Width="50%"/>
        <br /><br />
        
        Estado:<br />
        <asp:TextBox ID="txtEstado" runat="server" Width="30%"/>
        <br /><br />
        
        Tipo:<br />
        <asp:RadioButtonList ID="rblTipo" runat="server" >
            <asp:ListItem Value="Residencial"   Text="Residencial" />
            <asp:ListItem Value="Comercial"     Text="Comercial"/>
        </asp:RadioButtonList>
        <br /><br />
        
        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" OnClick="BtnCadastrarPessoa"/>
        
        <p>
            <asp:Label ID="lblMensagem" runat="server"/>
        </p>
    </div>
    </form>
</body>
</html>
