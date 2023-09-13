function Contact(){
    $.ajax({
        url: $('#requests').data('url'),
        type: 'GET',
    }).done(function(result){
        $('#requests').html(result);
    });
}

$(document).ready(function(){
    Contact();
});