/// <reference path = "jquery-1.8.2.js"/>
/// <reference path = "knockout-3.3.0.js"/>

var ViewModel = function () {
    this.retailAreas = ko.observableArray();
    this.beaconDetails = ko.observableArray();
    this.ShopId = ko.observable();
    this.BeaconId = ko.observable();
    this.selectedRetailArea = ko.observable();

    $.ajax({
        url: "/AddBeacon.aspx/GetRetailAreas",
        contentType: "application/json; charset=utf-8",
        type: "GET",
        success: function (data) {
            $.each(data.d, function (i, item) {
                retailAreas.push(item.Name);
            }.bind(ViewModel));
        },
        error: function (data) {
            alert("error occured");
        }
    });
    registerBeacon = function () {
        beaconDetails = { b: new beacon(ShopId(), BeaconId(), selectedRetailArea()) };
        var jsonData = ko.toJSON(beaconDetails);
        $.ajax({
            url: "/AddBeacon.aspx/AddBeacon",
            contentType: "application/json; charset=utf-8",
            type: "POST",
            data: jsonData,
            success: function (data) {
                $('#alert').append(
        '<div class="alert alert-success"><button type="button" class="close" data-dismiss="alert">' +
            '&times;</button>Your beacon is registered successfully!</div>');
            },
            error: function (data) {
                alert("error occured");
            }
        });
    }
    beacon = function (ShopId, BeaconId, selectedRetailArea) {
        var self = this;
        self.ShopId = ko.observable(parseInt(ShopId));
        self.BeaconID = ko.observable(parseInt(BeaconId));
        self.RetailAreaName = ko.observable(selectedRetailArea);
    }
};
$(document).ready(function () {
    ko.applyBindings(ViewModel);
});


