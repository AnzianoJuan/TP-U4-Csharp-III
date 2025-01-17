<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DireccionForm.aspx.cs" Inherits="Presentacion.DireccionForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="TextBoxId" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="TextBoxId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="TextBoxCalle" class="form-label">Calle</label>
                <asp:TextBox runat="server" ID="TextBoxCalle" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="TextBoxAltura" class="form-label">Altura</label>
                <asp:TextBox runat="server" ID="TextBoxAltura" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button ID="ButtonAgregarDireccion" CssClass="btn btn-primary" runat="server" OnClick="ButtonAgregarDireccion_Click" Text="Aceptar" />
                <asp:Button ID="ButtonModificarDireccion" CssClass="btn btn-primary" runat="server"  OnClick="ButtonModificarAuto_Click" Text="Modificar" />
                <a href="Default.aspx">Cancelar</a>
            </div>
            <asp:Label ID="LabelMensaje" runat="server" Text=""></asp:Label>
        </div>
    </div>

</asp:Content>
