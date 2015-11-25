// This event triggers on page load
document.addEventListener("DOMContentLoaded", function () {
    //calls the below defined funtion loadSpecials()
    loadSpecials();
});
function loadSpecials() {
    //call method getSpecials() defined in variable SpecialsModule in the specials.js file 
    SpecialsModule.getSpecials(setupSpecialsTable);
    
}
function setupSpecialsTable(specialslList) {
    var specialsTable = document.getElementById("specialsListID");
    //console.log(specialslList);

    for (i = 0; i < specialslList.length; i++) {
        var row = document.createElement("tr");

        var PicURLCol = document.createElement("td");
        PicURLCol.innerHTML = "<img src = \"" + specialslList[i].PicURL + "\" height = \"100\" width = \"100\">";
        row.appendChild(PicURLCol);


        var titleCol = document.createElement("td");
        titleCol.innerHTML = specialslList[i].Title;
        row.appendChild(titleCol);

        var descriptionCol = document.createElement("td");
        descriptionCol.innerHTML = specialslList[i].Description;
        row.appendChild(descriptionCol);

        var priceCol = document.createElement("td");
        priceCol.innerHTML = "$" + specialslList[i].Price.toFixed(2);

        row.appendChild(priceCol);

        specialsTable.appendChild(row);
    }


}