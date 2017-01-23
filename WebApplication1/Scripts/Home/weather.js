
$("#buttonId").click(function () {
    
    $.get("@Url.Action(\"GetWeather\", \"Home\")", function (response) {

        console.log(response);
        $("#name").text(response.name);
        $("#temp").text(response.main.temp);
        $("#humidity").text(response.main.humidity);
    });
});