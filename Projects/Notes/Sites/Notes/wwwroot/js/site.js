
$(document).ready(function () {
    $("#refresh-users-btn").on('click', function () {
        RefreshUsersTable();
    })

    $("#delete-users-btn").on('click', function () {
        var usersIds = $("#users input:checkbox:checked").map(function(){
            if ($(this).val() === "on") {
                return $(this).data('user-id');
            }
        }).get();
        
        var data = {
            usersIds: usersIds
        };

        $.ajax({
            url: '/api/noteUser/delete-users',
            data: JSON.stringify(data),
            method: "DELETE",
            contentType: 'application/json'
        }).done(function (data) {
            RefreshUsersTable();
        });
    })
})

function RefreshUsersTable(){
    $.ajax({
        url: '/api/noteUser/getall'
    }).done(function (data) {
        var usersTable = ''

        $.each(data.users, function (index, user) {
            usersTable += '<tr><td>' + user.id + '</td>'
            usersTable += '<td>' + user.name + '</td>'
            usersTable += '<td>' + user.age + '</td>'
            usersTable += '<td><input type="checkbox" data-user-id="' + user.id + '"></td></tr>'
        })

        $("#users").html(usersTable);
    });
}