$(document).ready(function () {

    $("#createButton").click(function () {
        var newcomerName = $("#nameField").val();

        $.ajax({
            method: "POST",
            url: "/Home/AddEmployee",
            data: {
                "name": newcomerName
            },
            success: (result) => {
                console.log(result);
                $("#employeeList").append(`<li>${newcomerName}</li>`);
                $("#nameField").val("");
            },
            error: function (err) {
                console.log(err);
            }
        })
    })
});