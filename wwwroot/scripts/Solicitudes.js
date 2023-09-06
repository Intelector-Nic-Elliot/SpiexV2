function Contacto(){
    $.ajax({
        url: $('#solicitudes').data('url'),
        type: 'GET',
    }).done(function(result){
        $('#solicitudes').html(result);
    });
}

$(document).ready(function(){
    Contacto();
});