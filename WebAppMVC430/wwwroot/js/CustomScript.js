
document.getElementById("welcome").style.color = "Red";

function getStates() {
    var e = document.getElementById("Country");
    var value = e.value;
    var text = e.options[e.selectedIndex].text;
    //alert(`Your Selected ${text} - ${value}`)
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch(`http://localhost:5136/state/CountryStates/${value}`, requestOptions)
        .then(response => response.text())
        .then(result => {
           
            var data = JSON.parse(result);
            console.log(data)
            State.innerHTML = '<option value="default">Select State</option>';
            for (var x in data) {
                var state = data[x];
                //console.log(data[x].name);
                var option = document.createElement("option");
                option.value = state.id;
                option.text = state.name;
                State.appendChild(option);

            }
            //for (const x in data) {
            //    const option = document.createElement("option");
            //    option.value = state;
            //    option.text = state;
            //    stateSelect.appendChild(option);
            //}
            //console.log(data)
        })
        .catch(error => console.log('error', error));
}
$(document).ready(function () {
    $("#Country").selectedIndex = 0;
    getStates();
});