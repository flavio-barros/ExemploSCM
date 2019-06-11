function formatar_descricao_mercadoria(value) {
    return "<h5>Descrição:</h5> <p>"+ value +"</p>";
}

$(document).ready(function () {
    var tabela_mercadoria = $(".tabela-mercadoria").DataTable({
        "language": {
            "decimal": "",
            "emptyTable": "Não existem mercadorias cadastradas",
            "info": "Mostrando _START_ - _END_ de _TOTAL_ mercadorias",
            "infoEmpty": "Mostrando 0 - 0 de 0 mercadorias",
            "infoFiltered": "(filtrado de um total de _MAX_ mercadorias)",
            "infoPostFix": "",
            "thousands": ".",
            "lengthMenu": "Mostrar _MENU_ mercadorias",
            "loadingRecords": "Carregando...",
            "processing": "Processando...",
            "search": "Pesquisar:",
            "zeroRecords": "Não existem mercadorias que satisfazem a pesquisa",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "sortAscending": ": activate to sort column ascending",
                "sortDescending": ": activate to sort column descending"
            }
        },
        "dom": '<"row justify-content-between" lpf>ti',
        "columnDefs": [{ orderable: false, targets: [4, 5] }],
        "lengthMenu": [5, 10, 20, 50]
    });

    $(".tabela-mercadoria tbody").on('click', 'td.details-control button', function () {
        var tr = $(this).closest('tr');
        var row = tabela_mercadoria.row(tr);

        var btn = $(this);
        var icon = $(this).find("i");

        console.log(btn.hasClass(""));

        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');

            btn.removeClass("btn-secondary");
            btn.addClass("btn-info");

            icon.removeClass("fa-minus-square");
            icon.addClass("fa-plus-square");

        } else {
            // Open this row
            row.child(formatar_descricao_mercadoria(tr.data('child-value'))).show();
            tr.addClass('shown');

            btn.removeClass("btn-info");
            btn.addClass("btn-secondary");

            icon.removeClass("fa-plus-square");
            icon.addClass("fa-minus-square");
        }
    });

    $('[data-tt="tooltip"]').tooltip();
});

$('#cadastrarMercadoria').trigger("reset");

$("#buttonResetCadMerc").click(function () {
    $('#cadastrarMercadoria')[0].reset();
});