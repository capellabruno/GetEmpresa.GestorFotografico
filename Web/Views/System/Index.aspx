<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Administrator.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.PortalConfigurationModels>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    System Configuration
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Configuração</h2>

    <%using (Html.BeginForm())
      { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary() %>
    <fieldset>
        <legend>Configuração do Usuário</legend>
        <ol>
            <li><%: Html.LabelFor(myForm => myForm.Facebook) %></li>
            <li><%: Html.EditorFor(myForm => myForm.Facebook) %></li>

            <li><%: Html.LabelFor(myForm => myForm.Twiter) %></li>
            <li><%: Html.EditorFor(myForm => myForm.Twiter) %></li>

            <li><%: Html.LabelFor(myForm => myForm.GooglePlus) %></li>
            <li><%: Html.EditorFor(myForm => myForm.GooglePlus) %></li>

            <li><%: Html.LabelFor(myForm => myForm.FormaPagamento) %></li>
            <li>
                <%: Html.DropDownListFor(myForm => myForm.FormaPagamento, new[]{ 
    new SelectListItem(){ Text = "..:: Selecione o Tipo de pagamento", Value = "" },
    new SelectListItem(){ Text = ""+ GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.BCash.ToString() +"", Value = "" + ((int)GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.BCash).ToString() + "", Selected = (( ((GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento)ViewBag.TipoPagamentoSelecionado) == GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.BCash)? true :false) }, 
    new SelectListItem(){ Text = "Boleto Bancário", Value = "" + ((int)GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.BoletoBancario).ToString() + "", Selected = (( ((GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento)ViewBag.TipoPagamentoSelecionado) == GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.BoletoBancario)? true :false)  },
    new SelectListItem(){ Text = "Depósito Bancário", Value = "" + ((int)GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.DepositoBancario).ToString() + "", Selected = (( ((GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento)ViewBag.TipoPagamentoSelecionado) == GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.DepositoBancario)? true :false)  },
    new SelectListItem(){ Text = ""+ GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PagSeguro.ToString() +"", Value = "" + ((int)GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PagSeguro).ToString() + "" , Selected = (( ((GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento)ViewBag.TipoPagamentoSelecionado) == GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PagSeguro)? true :false) },
    new SelectListItem(){ Text = ""+ GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PayPal.ToString() +"", Value = "" + ((int)GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PayPal).ToString() + "" , Selected = (( ((GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento)ViewBag.TipoPagamentoSelecionado) == GetEmpresa.GestorFotografico.Domain.Gerencial.EnumFormaPagamento.PayPal)? true :false) }
    }, new { @Style = "height: 30px; padding: 5px;", @onchange="javascript:alert('Ok');"})%>
                <%: Html.ValidationMessageFor(myForm => myForm.FormaPagamento) %>
            </li>

            <li><%: Html.LabelFor(myForm => myForm.CodigoBanco) %></li>
            <li><%: Html.EditorFor(myForm => myForm.CodigoBanco, new { @Style = "width: 40px;", @MaxLengthAttribute="3"}) %></li>

            <li><%: Html.LabelFor(myForm => myForm.Agencia) %></li>
            <li><%: Html.EditorFor(myForm => myForm.Agencia, new { @Style = "width: 60px;"}) %> - <%: Html.TextBoxFor(myForm => myForm.DigitoConta, new { @Style = "width: 20px;"}) %></li>

            <li><%: Html.LabelFor(myForm => myForm.ContaBanco) %></li>
            <li><%: Html.EditorFor(myForm => myForm.ContaBanco, new { @Style = "width: 60px;"}) %> - <%: Html.TextBoxFor(myForm => myForm.DigitoConta, new { @Style = "width: 20px;"})%></li>

            <li><%: Html.LabelFor(myForm => myForm.EmailPagSeguro) %></li>
            <li><%: Html.EditorFor(myForm => myForm.EmailPagSeguro) %></li>

            <li><%: Html.LabelFor(myForm => myForm.TokenPagSeguro) %></li>
            <li><%: Html.EditorFor(myForm => myForm.TokenPagSeguro) %></li>

            <li><%: Html.LabelFor(myForm => myForm.EmailPayPal) %></li>
            <li><%: Html.EditorFor(myForm => myForm.EmailPayPal) %></li>

            <li><%: Html.LabelFor(myForm => myForm.TokenPayPal) %></li>
            <li><%: Html.EditorFor(myForm => myForm.TokenPayPal) %></li>

        </ol>
        <input type="submit" value="Save" />
    </fieldset>

    <%} %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
