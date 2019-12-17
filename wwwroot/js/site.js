// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $.getJSON(base_url + "/json/hymns.json", function (data) {
        $.each(data, function (i, field) {
            $("#OpeningSongDropDown").append("<option value='" + field.songNumber + " " + field.name + "'>" + field.songNumber + " " + field.name + "</option>");
            $("#SacramentSongDropDown").append("<option value='" + field.songNumber + " " + field.name + "'>" + field.songNumber + " " + field.name + "</option>");
            $("#ClosingSongDropDown").append("<option value='" + field.songNumber + " " + field.name + "'>" + field.songNumber + " " + field.name + "</option>");

            
        });

        //alert( $("#OpeningSongDropDown").data("song") );
        //alert( $("#SacramentSongDropDown").data("song") );
        //alert($("#ClosingSongDropDown").data("song"));


        
        $("#OpeningSongDropDown").val($("#OpeningSongDropDown").data("song"));
        $("#SacramentSongDropDown").val($("#SacramentSongDropDown").data("song"));
        $("#ClosingSongDropDown").val($("#ClosingSongDropDown").data("song"));
    });


    $.fn.dataTable.moment('D MMMM YYYY');
    $('#speakers-list').DataTable({
        "columnDefs": [
            
            { "orderable": false, "targets": [3] }
        ]
        

    });
});


