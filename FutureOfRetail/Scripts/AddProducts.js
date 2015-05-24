/// <reference path = "jquery-1.8.2.js"/>
/// <reference path = "knockout-3.3.0.js"/>

var ViewModel = function () {
    this.product = ko.observableArray();
    this.ProductName = ko.observable();
    this.ProductDescription = ko.observable();
    this.ShopURL = ko.observable();
    this.ShopID = ko.observable();

    registerProduct = function () {
        newProduct = { p: new product(ProductName(), ProductDescription(), ShopURL(), ShopID()) };
        var jsonData = ko.toJSON(newProduct);
        $.ajax({
            url: "/Controllers/ProductController.aspx/AddProduct",
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
    product = function (ProductName, ProductDescription, ShopURL, ShopID) {
        var self = this;
        self.ShopId = ko.observable(parseInt(ShopID));
        self.Name = ko.observable(ProductName);
        self.Description = ko.observable(ProductDescription);
        self.Url = ko.observable(ShopURL);
    }
};
$(document).ready(function () {
    ko.applyBindings(ViewModel);
});