/// <reference path = "jquery-1.8.2.js"/>
/// <reference path = "knockout-3.3.0.js"/>


var ViewModel = function () {
    this.allBeacons = ko.observableArray();
    $.ajax({
        url: "/Controllers/BeaconController.aspx/GetAllBeacons",
        contentType: "application/json; charset=utf-8",
        type: "GET",
        success: function (data) {
            $.each(data.d, function (i, item) {

                allBeacons.push(item);
            }.bind(ViewModel));
        },
        error: function (data) {
            alert("error occured");
        }
    });
};
$(document).ready(function () {
    ko.applyBindings(ViewModel);
});


