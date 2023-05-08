<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Laboratorio11.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>ELIMINAR UNIVERSIDAD</h2>
    <p>Seleccione universidad:
        <asp:TextBox ID="TextBoxNombreUni" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="LabelUniversidad" runat="server" Text="UNIVERSIDAD"></asp:Label>
        <asp:Button ID="Button2" runat="server" Enabled="False" OnClick="Button2_Click" Text="Eliminar" />
    </p>
</asp:Content>
