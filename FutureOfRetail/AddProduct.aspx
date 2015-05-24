<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="FutureOfRetail._Default" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/bootstrap/jquery-1.11.2.js" type="text/javascript"></script>
    <script src="Scripts/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="Scripts/AddProducts.js" type="text/javascript"></script>
</asp:Content>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <p class="site-title">
                <a runat="server" href="~/" class="pull-left">
                    <img src="/Images/logo2.png" width="100" alt="Alternate Text" /></a>
            </p>
            <hgroup class="title">
                <h2><%: Title %></h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div id="alert"></div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Product Code:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Product Code" data-bind="value: ProductCode">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Product Name:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Product Name" data-bind="value: ProductName">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Product Description:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Product Description" data-bind="value: ProductDescription">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Product Image:</label>
        <div class="col-sm-10">
            <div class="fileinput fileinput-new" data-provides="fileinput">
                <input type="file" name="...">
            </div>
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Shop URL:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Enter Shop URL" data-bind="value: ShopURL">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Shop ID:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Enter Shop Id" data-bind="value: ShopID">
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <button class="btn btn-primary" data-bind="click: registerProduct">Register prodct</button>
        </div>
    </div>
</asp:Content>
