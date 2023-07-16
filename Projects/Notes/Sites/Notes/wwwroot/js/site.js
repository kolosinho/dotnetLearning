
$(document).ready(function () {
    var isDeteleBtnClicked = false;
    $("#refresh-users-btn").on('click', function () {
        RefreshUsersTable();
        isDeteleBtnClicked = false;
    })

    $("#delete-users-btn").on('click', function () {
        if (isDeteleBtnClicked === false) {
            //Event 1: Display checkboxes while 1st click
            $(".delete-th").removeAttr("style");
        } else {
            //Event 2: Delete user(s) & Page refresh while 2nd click
            var usersIds = $("#users input:checkbox:checked").map(function () {
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
        }
        isDeteleBtnClicked = !isDeteleBtnClicked;
    })

    function RefreshUsersTable() {
        $.ajax({
            url: '/api/noteUser/getall'
        }).done(function (data) {
            var usersTable = ''

            $.each(data.users, function (index, user) {
                usersTable += '<tr><td>' + user.id + '</td>'
                usersTable += '<td>' + user.name + '</td>'
                usersTable += '<td>' + user.age + '</td>'
                usersTable += '<td class="delete-th" style="display:none"><input type="checkbox" data-user-id="' + user.id + '"></td>'
                usersTable += '<td><a href="/NoteUser/Edit/' + user.id + '">Edit</a></td></tr>'
            })

            $("#users").html(usersTable);
            $(".delete-th").hide();
        });
    };
})