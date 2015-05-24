<%@ Page Title="All Active Beacons" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllBeacons.aspx.cs" Inherits="FutureOfRetail._Default" %>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="HeadContent">
    
    <script src="Scripts/bootstrap/jquery-1.11.2.js" type="text/javascript"></script>
    <script src="Scripts/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="Scripts/Beacons.js" type="text/javascript"></script>
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
    <div class="form-group">
                <div class="col-sm-10">
            <h2>Your Active Beacons</h2>
            <table class="table table-bordered>
                <thead style="font-size:18px;">
                    <tr><th>Beacon ID</th><th>Shop Name</th><th>Shop Area Name</th></tr>
                </thead>
                <tbody data-bind="foreach: allBeacons">
                    <tr style="font-size:17px;">
                        <td data-bind="text: BeaconId"></td>
                        <td data-bind="text: ShopName"></td>
                        <td data-bind="text: ShopAreaName"></td>
                    </tr>
                </tbody>
            </table>

        </div>
        
    </div>

</asp:Content>
