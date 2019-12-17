
$(document).ready(function () {
    getAllHeroes();
})

function getAllHeroes() {
    $.ajax({
        url: "service/Serve.svc/GetAllHeroes",
        type: "Get",
        dataType: "json",
        success: function (result) {
            console.log(result);
            drawHeroTable(result);
        }
    });
}

function drawHeroTable(result) {
    $DisplayArea = $("#Tbody");
    $DisplayArea.empty();
    for (var i = 0; i < result.length; i++) {
        $tr = $("<tr>").attr('id',result[i].id);
        $("<td>").html(result[i].id).appendTo($tr);
        $("<td>").html(result[i].FirstName).appendTo($tr);
        $("<td>").html(result[i].LastName).appendTo($tr);
        $("<td>").html(result[i].HeroName).appendTo($tr);
        $("<td>").html(result[i].PlcaeOfBirth).appendTo($tr);
        $("<td>").html(result[i].Combat).appendTo($tr);
        $("<td>").appendTo($tr).append("<button onclick='editHero(" + result[i].Id + ")'>Edit</button>");
        $("<td>").appendTo($tr).append("<button onclick='deleteHero(" + result[i].Id + ")'>Delete</button>");
        $tr.appendTo($DisplayArea);
    }
}

function addHero() {
    var Hero = {
        "id": 0,
        "FirstName": $("#FirstName").val(),
        "LastName": $("#LastName").val(),
        "HeroName": $("#HeroName").val(),
        "PlcaeOfBirth": $("#PlcaeOfBirth").val(),
        "Combat": $("#Combat").val()
    };
    $.ajax({
        url: "service/Serve.svc/AddHeros",
        type: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(Hero),
        success: function (result) {
            getAllHeroes();
        }
    })
}

function editHero() {
    ableDisable()
}
function deleteHero() {
    window.alert("Oh yes !");
}

function ableDisable() {
    switch()
}