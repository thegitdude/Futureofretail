<%@ Page Title="Register your BeeList beacon" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FutureOfRetail._Default" %>

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
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Shop Id:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Shop Id">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Beacon Id:</label>
        <div class="col-sm-10">
            <input type="text" class="form-control" placeholder="Enter Beacon Id">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-2" for="email">Section:</label>
        <div class="col-sm-10">
            <select class="col-md-6 col-sm-6">
                <option value="food">Food</option>
                <option value="clothing">Clothing</option>
                <option value="nonfood">Non-Food</option>
            </select>
        </div>
    </div>

    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <button type="submit" class="btn btn-primary">Submit</button>
        </div>
    </div>
</asp:Content>
