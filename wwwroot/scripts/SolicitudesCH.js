function ContactoCH(){
    $.ajax({
        url: $('#solicitudesCH').data('url'),
        type: 'GET',
    }).done(function(result){
        $('#solicitudesCH').html(result);
    });
}

$(document).ready(function(){
    Contacto();
});