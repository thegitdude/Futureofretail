<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FutureOfRetail._Default" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="HeadContent">
    <link rel="stylesheet" href="css/demo-styles.css" />
    <script src="Scripts/jquery-1.8.2.js"></script>
    <script src="Scripts/scripts.js"></script>
    <script src="Scripts/modernizr-2.6.2.js"></script>
</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="text-center">
            <img src="/Images/logo.png" alt="Alternate Text" />
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="DashboardContent">
    <div class="demo-wrapper">
        <!-- classnames for the pages should include: 1) type of page 2) page name-->
        <!--each tile should specify what page type it opens (to determine which animation) and the corresponding page name it should open-->
        <div class="dashboard clearfix">
            <ul class="tiles">
                <div class="col1 clearfix">
                    <li class="tile tile-big tile-1a slideTextUp" onclick="location.href='addbeacon.aspx';" data-page-type="r-page" data-page-name="random-r-page">
                        <div>
                            <p>Add new beacon</p>
                        </div>
                        <div>
                            <p>Add new beacon</p>
                        </div>
                    </li>
                    <li class="tile tile-big tile-2a slideTextUp" onclick="location.href='addproduct.aspx';" data-page-type="r-page" data-page-name="random-r-page">
                        <div>
                            <p>Add product</p>
                        </div>
                        <div>
                            <p>Add product</p>
                        </div>
                    </li>
                </div>

                <div class="col2 clearfix" onclick="location.href='allbeacons.aspx';">
                    <li class="tile tile-big tile-1b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
                        <div>
                            <p>See all beacons</p>
                        </div>
                        <div>
                            <p>See all beacons</p>
                        </div>
                    </li>
                    <li class="tile tile-big tile-2b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
                        <div>
                            <p>Feedback tool</p>
                        </div>
                        <div>
                            <p>Feedback tool</p>
                        </div>
                    </li>
                </div>

                <div class="col3 clearfix">
                    <li class="tile tile-big tile-1c slideTextUp" data-page-type="r-page" data-page-name="random-r-page" onclick="location.href='customerstatistics.aspx'">
                        <div>
                            <p>See statistics</p>
                        </div>
                        <div>
                            <p>See statistics</p>
                        </div>
                    </li>
                    <li class="tile tile-big tile-1b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
                        <div>
                            <p>Help</p>
                        </div>
                        <div>
                            <p>Help</p>
                        </div>
                    </li>
                </div>
            </ul>
        </div>

    </div>
</asp:Content>

