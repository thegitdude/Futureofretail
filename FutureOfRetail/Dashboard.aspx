<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FutureOfRetail.Dashboard" %>

<!DOCTYPE html>
<html>
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <title>Windows-8-like Animations with CSS3 and jQuery</title>

  <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

</head>

<body>
 <header>
  
 </header>
  <!--===============================Start Demo====================================================-->
<div class="demo-wrapper">
<!-- classnames for the pages should include: 1) type of page 2) page name-->
<!--each tile should specify what page type it opens (to determine which animation) and the corresponding page name it should open-->
  <div class="dashboard clearfix">
    <ul class="tiles">
      <div class="col1 clearfix">
        <li class="tile tile-big tile-a slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
        <li class="tile tile-big tile-b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new product</p></div>
          <div><p>Add new product</p></div>
        </li>
      </div>

      <div class="col2 clearfix">
        <li class="tile tile-big tile-d slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
        <li class="tile tile-big tile-e slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
      </div>

      <div class="col3 clearfix">      
        <li class="tile tile-big tile-g slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
        <li class="tile tile-big tile-h slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
      </div>
    </ul>
  </div><!--end dashboard-->

</div>
<!--====================================end demo wrapper================================================-->
  <script src="js/jquery-1.8.2.min.js"></script>
  <script src="js/scripts.js"></script>

</body>
</html>

