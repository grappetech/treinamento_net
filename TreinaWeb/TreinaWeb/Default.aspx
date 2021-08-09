<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TreinaWeb._Default" %>

<%@ Register Assembly="DevExpress.Web.v20.1, Version=20.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <div class="row">
        <div class="container">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtTitulo" ID="lblTitulo">
                    Título
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtResponsavel" ID="Label1">
                    Responsável
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtResponsavel" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtData" ID="Label2">
                    Data Da Tarefa
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtData" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtPrazo" ID="Label3">
                    Prazo da Tarefa
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtPrazo" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtFinalizadoEm" ID="Label4">
                    Data de Finalização
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtFinalizadoEm" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtDescricao" ID="Label5">
                    Descrição da Tarefa
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtDescricao" CssClass="form-control" Rows="6"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="chkFinalizado" ID="Label6">
                    Finalizado
                    </asp:Label>
                    <asp:CheckBox runat="server" ID="chkFinalizado"></asp:CheckBox>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="control-label" runat="server" AssociatedControlID="txtPrioridade" ID="Label7">
                    Prioridade da Tarefa
                    </asp:Label>
                    <asp:TextBox runat="server" ID="txtPrioridade" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="btnSalvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" Text="Salvar" /> 
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="btnExcluir" CssClass="btn btn-danger" OnClick="btnExcluir_Click" Text="Salvar" /> 
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="col">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-responsive table-condensed table-bordered">
            </asp:GridView>
        </div>
    </div>

</asp:Content>
