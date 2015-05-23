<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="FutureOfRetail.Product" MasterPageFile="~/Site.Mobile.Master" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="HeadContent">
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
    <div>
        <div class="col-lg-12">
            <img src=""/>
        </div>
    </div>
</asp:Content>
