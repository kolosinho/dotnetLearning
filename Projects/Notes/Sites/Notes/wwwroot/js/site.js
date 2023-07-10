
$( document ).ready(function() {
    $( "#refresh-users-btn" ).on( 'click', function() {
        $.ajax({
            url: '/api/noteUser'
        }).done(function(data) {
            var newData = "";
            data.users.forEach(user => newData += '<p>' + user.name + '</p>' + '<hr><br>')
            $('#users').empty().append(newData);
        });
    });
});