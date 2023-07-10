
$(document).ready(function () {
    $("#refresh-users-btn").on('click', function () {
        $.ajax({
            url: '/api/noteUser'
        }).done(function (data) {
            var usersTable = '' 

            $.each(data.users, function (index, user) {                
                usersTable += '<tr><th scope="row">' + user.id + '</th>'
                usersTable += '<td>' + user.name + '</td>'
                usersTable += '<td>' + user.age + '</td>'
                usersTable += '<td><input type="checkbox"></td></tr>'
            })


            $("#users").html(usersTable);

            //data.users.forEach(user => newData += '<p>' + user.name + '</p>' + '<hr><br>')
            //$('#users').empty().append(newData);
        });
    })
})