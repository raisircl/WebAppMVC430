
document.getElementById("welcome").style.color = "Red";

function getCountry() {
    var e = document.getElementById("Loc");
    var value = e.value;
    var text = e.options[e.selectedIndex].text;
    alert(`Your Selected ${text} - ${value}`)
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch(`http://localhost:5136/state/CountryStates/${value}`, requestOptions)
        .then(response => response.text())
        .then(result => {
           
            var data = JSON.parse(result);
            console.log(data)
        })
        .catch(error => console.log('error', error));
}
//$(document).ready(function () {
//    $("#Loc").change(function () {

//        alert("You have selected: " + $("#Loc option:selected").text());
//    });
//});