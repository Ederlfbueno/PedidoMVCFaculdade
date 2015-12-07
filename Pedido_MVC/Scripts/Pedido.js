function SalvaPedido() {
    debugger;

    // Data

    var data = $("#DataPedido").val();

    var dataent = $("#PrevisaoEntrega").val();

    var cliente = $("#ClienteId").val();

    var valor = $("#Total").val();

    var token = $('input[name"__RequestVerificationToken"]').val();
    var tokenadr = $('form[action=/Pedidos/Create')

    var headers = {};
    var headeradr = {};
    
    headers = ['__RequestVerificationToken'] = token;
    headersadr = ['__RequestVerificationToken'] = tokenadr;

    // gravar

    var url = "/Pedidos/Create";
    $.ajax
        ({
            url: url
            , type: "POST"
            , datatype: "json"
            , headers: headeradr
            , data: {Id:0, Data: data, PevisaoEntrega: dataent, Cliente: cliente, Valor: valor, __RequestVerificationToken: token }
            , sucess : function(data)
            {
                if (data.Resultado > 0 )
                {
                    debugger;
                    ListarItens(data.Resultado);
                }
            }
        });

}

function ListarItens(idPedido)
{
    var url = "/PedidoProdutos/ListarItens";

    $.ajax
    ({
        url: url
        , type: "GET"
        , data: { id: idPedido }
        , datatype: "html"
        , sucess: function (data) {
            var divItens = $("#divItens");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });
}