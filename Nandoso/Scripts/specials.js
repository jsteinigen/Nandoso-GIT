var SpecialsModule = (function () {
    //Only functions returned from this closure is exposed and can be accessed
    return {
        getSpecials: function (callback) {
            //Code to make API calls goes here
           
            //accessing JQuery for API
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "https://aklnandoso.azurewebsites.net/api/Specials",
                success: function (data) {
                    callback(data);
                }
            });
        }
    }
}());