/********************
*
*
*
*
*
*/




function SearchCep(valueCep) {

    var urlOnline = "http://cep.correiocontrol.com.br/";

    if ($.trim(valueCep) == "")
    {
        alert('Cep deve ser informado');
        $("#Cep").focus();
    }

    $.getJSON(urlOnline + valueCep + ".json", {}, function (a) { PreencheInfoCEP(a); },null);

}
function PreencheInfoCEP(data) {
    if (data.erro != undefined) {
        $("#Cep").focus();
        alert('Cep informado é inválido');
    }

    $("#Endereco").val(data.logradouro);
    $("#Bairro").val(data.bairro);
    $("#Cidade").val(data.localidade);
    $("#Uf").val(data.uf);
    $("#Pais").val("Brasil");    
}