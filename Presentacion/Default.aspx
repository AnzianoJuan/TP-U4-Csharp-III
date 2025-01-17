<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .oclulto {
            display: none;
        }
    </style>


    <div class="row">
        <div class="col">
            <asp:GridView ID="GridViewDireccion" CssClass="table table-dark" DataKeyNames="Id" OnSelectedIndexChanged="GridViewDireccion_SelectedIndexChanged" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Calle" DataField="Calle" />
                    <asp:BoundField HeaderText="Altura" DataField="Altura" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <a href="DireccionForm.aspx">Agregar</a>

</asp:Content>
