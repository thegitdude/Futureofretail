/// <reference path = "jquery-1.8.2.js"/>
/// <reference path = "knockout-3.3.0.js"/>

var ViewModel = function () {
    this.retailAreas = ko.observableArray();
    $.ajax({
        url: "/Default.aspx/GetRetailAreas",
        contentType: "application/json; charset=utf-8",
        type: "GET",
        success: function (data) {
            $.each(data.d, function (innerObj,index) {
                retailAreas.push(index.Name);
            });
        },
        error: function (data) {
            alert("error occured");
        }
    });
};
ko.applyBindings(ViewModel);

