$(function () {
    $('[data-tt="tooltip"]').tooltip()
})

$('#cadastrarMercadoria').trigger("reset");

$("#buttonResetCadMerc").click(function () {
    $('#cadastrarMercadoria')[0].reset();
});
