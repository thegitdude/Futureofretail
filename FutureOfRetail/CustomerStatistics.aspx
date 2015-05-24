<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerStatistics.aspx.cs" Inherits="FutureOfRetail.CustomerStatistics" MasterPageFile="~/Site.Master"%>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/Chart.js" type="text/javascript"></script>
    <script src="Scripts/statistics.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap/jquery-1.11.2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            statistics.loadProductChart();
            setInterval(function () {
                statistics.loadProductChart();
                /* other code here as required */
            }, 5000);
        });
    </script>
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
    <div class="row">
        <input value="Beacon traffic" class="btn btn-info col-lg-4"/>
        
        <input  value="Bar-code usage" class="btn btn-info col-lg-4"/>
           
        <input value="Product interest" class="btn btn-info col-lg-4"/>
        </div>
    <div class="row" style="height:20px;"></div>
   <canvas id="myChart" width="950" height="400"></canvas>
</asp:Content>
