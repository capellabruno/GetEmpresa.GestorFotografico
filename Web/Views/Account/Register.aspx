<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.FotografoModels>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Register.</h1>
        <h2>Create a new account.</h2>
    </hgroup>

    <% using (Html.BeginForm())
       { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary() %>

    <fieldset>
        <legend>Registration Form</legend>
        <ol>
            <li>
                <%: Html.LabelFor(m => m.Nome) %>
                <%: Html.TextBoxFor(m => m.Nome) %>
            </li>
            <li>
                <%: Html.LabelFor(m => m.Email) %>
                <%: Html.TextBoxFor(m => m.Email, new{ @Style="width: 350px;" }) %> (Será o usuário de acesso)
            </li>
            <li>
                <%: Html.LabelFor(p => p.Telefone) %>
                <%: Html.TextBoxFor(p => p.Telefone, "(99) 99999-9999") %>
            </li>
            <li>
                <%: Html.LabelFor(p => p.Documento) %>
                <%: Html.TextBoxFor(p => p.Documento) %>
            </li>
            <li>
                <%: Html.Label("CEP / Endereço / Complemento") %>
                <%: Html.TextBoxFor(m => m.Cep, new { @Style = "width: 100px;", maxlength = 10, onblur = "javascript:SearchCep(this.value);" })%> - 
                <%: Html.TextBoxFor(m => m.Endereco, new{ @Style="width: 250px;", @readonly="readyonly" }) %>                                        

                <%: Html.TextBoxFor(m => m.Complemento, new{ @Style="width: 150px;" }) %>                                                             
            </li>
            <li>
                <%: Html.Label("Bairro / Cidade / UF / País") %>
                <%: Html.TextBoxFor(m => m.Bairro, new{ @Style="width: 150px;", @readonly="readyonly" }) %> -
                <%: Html.TextBoxFor(m => m.Cidade, new{ @Style="width: 150px;", @readonly="readyonly" }) %> - 
                <%: Html.TextBoxFor(m => m.Uf, new{ @Style="width: 50px;", @readonly="readyonly" }) %> -                                                     
                <%: Html.TextBoxFor(m => m.Pais,new{ @Style="width: 100px;", @readonly="readyonly" }) %>
            </li>

            <li>
                <%: Html.LabelFor(m => m.Senha) %>
                <%: Html.PasswordFor(m => m.Senha, new { @style="width: 150px;" })%> <b>(senha deve conter letras e números e ter pelo menos 1 letra maiúscula e 1 letra minuscula e ter no mínimo 8 caracteres).</b>
            </li>
        </ol>
        <input type="submit" value="Create Account" />
    </fieldset>
    <% } %>
</asp:Content>

<asp:Content ID="scriptsContent" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
    <%: Scripts.Render("~/Scripts/jsSupport.js") %>
</asp:Content>
